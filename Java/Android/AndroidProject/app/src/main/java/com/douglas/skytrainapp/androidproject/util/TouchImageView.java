package com.douglas.skytrainapp.androidproject.util;

import android.content.Context;
import android.graphics.PointF;
import android.graphics.drawable.Drawable;
import android.graphics.Matrix;
import android.util.AttributeSet;
import android.util.Log;
import android.view.MotionEvent;
import android.view.ScaleGestureDetector;
import android.view.View;
import android.widget.ImageView;

public class TouchImageView extends ImageView {
    //field
    Matrix matrix;
    int viewWidth, viewHeight;
    protected float origWidth, origHeight;
    int oldMeasuredWidth, oldMeasuredHeight;
    ScaleGestureDetector mScaleDetector;
    Context context;

    // Global static variables
    static final int none = 0;//the value before user touches
    static final int drag = 1;//the value when user touches and dDrag image
    static final int zoom = 2;//the value after zooming
    static final int click = 3;//when user clicks(touches)

    //the mode at very beginning (before user touches)
    int mode = none;

    //For zooming
    PointF lastPoint = new PointF();
    PointF startPoint = new PointF();
    //PointF is a class that holds two float coordinates (x,y)

    //Variables for minimum scale(measurement)
    // and maximum scale in float type
    float minScale = 1f; //lowercase 'f' for float
    float maxScale = 3f;
    float[] m;

    //Saving measurements
    float saveScale = 1f;

    //Overloading TouchImageView inheriting context
    // and AttributeSet to initialize
    public TouchImageView(Context context) {
        super(context);
        sharedConstructing(context);
    }

    public TouchImageView(Context context, AttributeSet attrs) {
        super(context, attrs);
        sharedConstructing(context);
    }

    //OverWrite shareConstructing()
    private void sharedConstructing(Context context) {

        super.setClickable(true);

        this.context = context;

        mScaleDetector = new ScaleGestureDetector(context, new ScaleListener());

        matrix = new Matrix();

        m = new float[9];

        setImageMatrix(matrix);

        setScaleType(ScaleType.MATRIX);

        //Calling setOnTouchListener
        setOnTouchListener(new OnTouchListener() {

            @Override
            public boolean onTouch(View v, MotionEvent event) {

                mScaleDetector.onTouchEvent(event);

                PointF currentPos = new PointF(event.getX(), event.getY());

                switch (event.getAction()) {

                    //Once user touches (this starts the gesture).
                    case MotionEvent.ACTION_DOWN://the index is 0 in MotionEvent
                        //So once user touches, the current position
                        // is the last position.
                        lastPoint.set(currentPos);

                        //And the last position is the start position
                        startPoint.set(lastPoint);

                        mode = drag;

                        break;

                    case MotionEvent.ACTION_MOVE:
                        //A change has happened during a press gesture.
                        if (mode == drag) {

                            //X and Y position changing
                            float deltaX = currentPos.x - lastPoint.x;

                            float deltaY = currentPos.y - lastPoint.y;

                            float fixTransX = getFixdDragTrans
                                    (deltaX, viewWidth, origWidth * saveScale);

                            float fixTransY = getFixdDragTrans
                                    (deltaY, viewHeight, origHeight * saveScale);

                            matrix.postTranslate(fixTransX, fixTransY);

                            fixTrans();

                            //set lastPoint to make the current zoomed image size fixed
                            lastPoint.set(currentPos.x, currentPos.y);

                        }

                        break;
                    //Sent when the last pointer leaves the screen.
                    case MotionEvent.ACTION_UP:

                        mode = none;

                        int xDiff = (int) Math.abs(currentPos.x - startPoint.x);

                        int yDiff = (int) Math.abs(currentPos.y - startPoint.y);

                        if (xDiff < click && yDiff < click)

                            performClick();

                        break;

                    //Sent when a non-primary pointer goes up.
                    case MotionEvent.ACTION_POINTER_UP:

                        mode = none;
                        break;

                }

                setImageMatrix(matrix);

                invalidate();

                return true; // indicate event was handled

            }

        });
    }

    public void setMaxZoom(float x) {
        //the X coordinate of image
        maxScale = x;

    }

    private class ScaleListener extends ScaleGestureDetector.SimpleOnScaleGestureListener {

        @Override
        public boolean onScaleBegin(ScaleGestureDetector detector) {

            mode = zoom;
            return true;

        }

        @Override
        public boolean onScale(ScaleGestureDetector detector) {

            float mScaleFactor = detector.getScaleFactor();

            float origScale = saveScale;

            saveScale *= mScaleFactor;

            if (saveScale > maxScale) {

                saveScale = maxScale;

                mScaleFactor = maxScale / origScale;

            } else if (saveScale < minScale) {

                saveScale = minScale;

                mScaleFactor = minScale / origScale;

            }

            if (origWidth * saveScale <= viewWidth || origHeight * saveScale <= viewHeight)

                matrix.postScale(mScaleFactor, mScaleFactor, viewWidth / 2, viewHeight / 2);

            else

                matrix.postScale(mScaleFactor, mScaleFactor, detector.getFocusX(), detector.getFocusY());

            fixTrans();

            return true;

        }

    }

    void fixTrans() {

        matrix.getValues(m);

        float transX = m[Matrix.MTRANS_X];

        float transY = m[Matrix.MTRANS_Y];

        float fixTransX = getFixTrans(transX, viewWidth, origWidth * saveScale);

        float fixTransY = getFixTrans(transY, viewHeight, origHeight * saveScale);

        if (fixTransX != 0 || fixTransY != 0)

            matrix.postTranslate(fixTransX, fixTransY);

    }



    float getFixTrans(float trans, float viewSize, float contentSize) {

        float minTrans, maxTrans;

        if (contentSize <= viewSize) {

            minTrans = 0;

            maxTrans = viewSize - contentSize;

        } else {

            minTrans = viewSize - contentSize;

            maxTrans = 0;

        }

        if (trans < minTrans)

            return -trans + minTrans;

        if (trans > maxTrans)

            return -trans + maxTrans;

        return 0;

    }

    float getFixdDragTrans(float delta, float viewSize, float contentSize) {

        if (contentSize <= viewSize) {

            return 0;

        }

        return delta;

    }

    @Override
    protected void onMeasure(int widthMeasureSpec, int heightMeasureSpec) {

        super.onMeasure(widthMeasureSpec, heightMeasureSpec);

        viewWidth = MeasureSpec.getSize(widthMeasureSpec);

        viewHeight = MeasureSpec.getSize(heightMeasureSpec);

        //
        // Rescales image on rotation
        //
        if (oldMeasuredHeight == viewWidth && oldMeasuredHeight == viewHeight

                || viewWidth == 0 || viewHeight == 0)

            return;

        oldMeasuredHeight = viewHeight;

        oldMeasuredWidth = viewWidth;

        if (saveScale == 1) {

            //Fit to screen.

            float scale;

            Drawable drawable = getDrawable();

            if (drawable == null || drawable.getIntrinsicWidth() == 0 || drawable.getIntrinsicHeight() == 0)

                return;

            int bmWidth = drawable.getIntrinsicWidth();

            int bmHeight = drawable.getIntrinsicHeight();

            Log.d("bmSize", "bmWidth: " + bmWidth + " bmHeight : " + bmHeight);

            float scaleX = (float) viewWidth / (float) bmWidth;

            float scaleY = (float) viewHeight / (float) bmHeight;

            scale = Math.min(scaleX, scaleY);

            matrix.setScale(scale, scale);

            // Center the image
            float redundantYSpace = (float) viewHeight - (scale * (float) bmHeight);
            float redundantXSpace = (float) viewWidth - (scale * (float) bmWidth);

            redundantYSpace /= (float) 2;

            redundantXSpace /= (float) 2;

            matrix.postTranslate(redundantXSpace, redundantYSpace);

            origWidth = viewWidth - 2 * redundantXSpace;

            origHeight = viewHeight - 2 * redundantYSpace;

            setImageMatrix(matrix);

        }

        fixTrans();

    }
}

