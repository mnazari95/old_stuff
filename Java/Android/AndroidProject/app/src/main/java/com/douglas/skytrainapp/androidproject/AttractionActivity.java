package com.douglas.skytrainapp.androidproject;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.os.Handler;
import android.text.Html;
import android.text.Spannable;
import android.text.method.LinkMovementMethod;
import android.text.method.ScrollingMovementMethod;
import android.text.style.ClickableSpan;
import android.view.View;
import android.view.animation.AlphaAnimation;
import android.view.animation.Animation;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class AttractionActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_attractions);
        String param = getIntent().getStringExtra("imageId");
        String myString ="";
        String url = "";

        switch (param)
        {
            case "waterfront":
                setImage(param);
                blink("Canada Place");
                myString = "Canada Place, Located in the heart of downtown Vancouver's waterfront, is an internationally recognized world class facility. Canada Place holds inspirationally events year round. " +
                        "Canada Place brings free world-class community events to residents and visitors alike." +
                        " It's a place to walk across our great nation on The Canadian Trail, take a ride on FlyOver Canada, or watch the Sails of Light nightly. For More Information: [Click Here]";
                url = "http://www.canadaplace.ca/";
                linkableText(myString, url);
                break;
            case "vancitycentre":
                setImage(param);
                blink("Pacific Center Mall");
                myString = "CF Pacific Centre is a shopping mall located in Vancouver, British Columbia, Canada. " +
                        "It is operated by Cadillac Fairview Corporation. Based on the number of stores, " +
                        "most of which are underground, it is the largest mall in Downtown Vancouver with over 100 stores and shoppes. For More Information: [Click Here]";
                url = "https://www.cfshops.com/pacific-centre.html";
                linkableText(myString, url);
                break;
            case "scienceworld":
                setImage(param);
                blink("Science World");
                myString = "Science World is a charitable organization that engages British Columbians in science " +
                        "and inspires future science and technology leadership throughout our province. " +
                        " A Science World Membership pays for itself in 2.5 visits. For More Information: [Click Here]";
                url = "http://www.scienceworld.ca/";
                linkableText(myString, url);
                break;
            case "rupert":
                setImage(param);
                blink("Hastings Racecourse");
                myString = "Hastings Racecourse is a horse racing facility at Hastings Park four miles from downtown Vancouver, British Columbia, Canada. Originally called East Park, " +
                        "it opened for business in 1889, making it Vancouver's longest continuously used professional sports facility. The racing operation is currently a " +
                        "wholly owned subsidiary of Great Canadian Gaming Corporation who acquired the lease of the city-owned track in 2004.. For More Information: [Click Here]";
                url = "http://www.hastingsracecourse.com/";
                linkableText(myString, url);
                break;
            case "renfrew":
                setImage(param);
                blink("Playland Amusement Park");
                myString = "Playland is an amusement park in Vancouver, British Columbia, Canada. " +
                        "It is located in Hastings Park and is the oldest amusement park in Canada.. For More Information: [Click Here]";
                url = "http://www.pne.ca/playland/index.html";
                linkableText(myString, url);
                break;
            case "chinatown":
                setImage(param);
                blink("Classical Chinese Garden");
                myString = "The Dr. Sun Yat-Sen Classical Chinese Garden is located in Chinatown in Vancouver, British Columbia, Canada. " +
                        "It is located at 578 Carrall Street and consists of a freely accessible public park and a garden with an admission fee. " +
                        "The mandate of the garden is to maintain and enhance the bridge of understanding between Chinese and western cultures, " +
                        "promote Chinese culture generally and be an integral part of the local community. For More Information: [Click Here]";
                url = "http://vancouverchinesegarden.com/";
                linkableText(myString, url);
                break;
            case "granville":
                setImage(param);
                blink("Vogue Theatre");
                myString = "Locally owned and operated the Vogue Theatre is one of the last remaining theatres from the famed “Theatre Row”. " +
                        "Located in the heart of downtown Vancouver on Granville Street, " +
                        "the Vogue is a graceful reminder of the Vancouver of old.. For More Information: [Click Here]";
                url = "http://voguetheatre.com/";
                linkableText(myString, url);
                break;
            case "burrad":
                setImage(param);
                blink("Marine Building");
                myString = "The Marine Building is a skyscraper located at 355 Burrard Street in Downtown Vancouver, British Columbia, Canada near the Financial District, designed by McCarter Nairne and Partners. " +
                        "It is renowned for its Art Deco details and for a time for being the tallest building in the British Empire. For More Information: [Click Here]";
                url = "http://www.vancouverhistory.ca/archives_marine_building.htm";
                linkableText(myString, url);
                break;
            case "yaletown":
                setImage(param);
                blink("BC Place");
                myString = "BC Place is a multi-purpose stadium located at the north side of False Creek, in Vancouver, British Columbia, Canada. " +
                        "It is owned and operated by the BC Pavilion Corporation, a crown corporation of the province. For More Information: [Click Here]";
                url = "https://www.bcplacestadium.com/";
                linkableText(myString, url);
                break;
            case "bridgeport":
                setImage(param);
                blink("River Rock Casino Resort");
                myString = " River Rock Casino Resort in Richmond, British Columbia is the largest casino in the province of British Columbia. The casino is owned by Great Canadian Gaming. " +
                        "There is a total of 396 rooms, including standard rooms and suites and it is situated on the river with a 144-berth marina. For More Information: [Click Here]";
                url = "http://www.riverrock.com/";
                linkableText(myString, url);
                break;
            case "kingedward":
                setImage(param);
                blink("VanDusen Botanical Garden");
                myString = "VanDusen Botanical Garden is situated in Vancouver, British Columbia, Canada. " +
                        "Named for local lumberman and philanthropist Whitford Julian VanDusen, it has been a public garden since its opening on " +
                        "August 30, 1975. For More Information: [Click Here]";
                url = "http://vandusengarden.org/";
                linkableText(myString, url);
                break;
            case "cityhall":
                setImage(param);
                blink("Old Hastings Mill Store Museum");
                myString = "Hastings Mill was a sawmill on the south shore of Burrard Inlet and " +
                        "was the first commercial operation around which the settlement that would become Vancouver developed in " +
                        "British Columbia, Canada. For More Information: [Click Here]";
                url = "http://www.hastings-mill-museum.ca/";
                linkableText(myString, url);
                break;
            case "langara":
                setImage(param);
                blink("Langara Golf Course");
                myString = "Langara Golf Course is a traditional-style course located on the south slope of Vancouver. " +
                        "Built in 1926 by the Canadian Pacific Railway, the course was redesigned by Canadian Architect Thomas McBroom. For More Information: [Click Here]";
                url = "http://vancouver.ca/parks-recreation-culture/langara-golf-course.aspx";
                linkableText(myString, url);
                break;
            case "metrotown":
                setImage(param);
                blink("Metropolis at metrotown");
                myString = "Metropolis at Metrotown (commonly referred to as simply Metrotown or Metro, and formerly known as Metrotown Centre, or Eaton Centre Metrotown) " +
                        "is a shopping mall complex in Metrotown, Burnaby, British Columbia, Canada. It is the largest mall in British Columbia, and the 2nd largest in Canada. The mall is connected by a skyway to " +
                        "the Metrotown Station on the SkyTrain rapid transit system. Three office buildings are part of the complex. For More Information: [Click Here]";
                url = "http://metropolisatmetrotown.com/";
                linkableText(myString, url);
                break;

            case "airport":
                setImage(param);
                blink("Vancouver Airport");
                myString = "Vancouver International Airport is located on Sea Island in Richmond, British Columbia, Canada, about from Downtown Vancouver. In 2014, " +
                        "it was the second busiest airport in Canada by aircraft movements and passengers, behind Toronto Pearson International Airport. For More Information: [Click Here]";
                url = "http://www.yvr.ca/";
                linkableText(myString, url);
                break;
            case "patterson":
                setImage(param);
                blink("Central Park");
                myString = "Central Park is a 90-hectare (222 acre) urban park in Burnaby, British Columbia, founded in 1891." +
                        " The park is on the Vancouver-Burnaby border, just west of the Metropolis at Metrotown shopping complex, and is bounded by " +
                        "Boundary Road on the west, Kingsway on the north, Patterson and Willingdon Avenues on the east, and Imperial Road on the south. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/Things-To-Do/Explore-Outdoors/Parks/Central-Park.html";
                linkableText(myString, url);
                break;
            case "oakridge":
                setImage(param);
                blink("Queen Elizabeth Park");
                myString = "Queen Elizabeth Park is a 130-acre[1] municipal park located in Vancouver, British Columbia, Canada, on Little Mountain (elevation approximately 152 metres[2] or 500 feet above sea level). " +
                        "Its surface was scarred at the turn of the twentieth century when it was quarried for its rock, which served to build Vancouver's first roadways. For More Information: [Click Here]";
                url = "http://vancouver.ca/parks-recreation-culture/queen-elizabeth-park.aspx";
                linkableText(myString, url);
                break;
            case "vccclark":
                setImage(param);
                blink("China Creek Park North");
                myString = "China Creek North is a large open space with a popular jogging track, open fields, and playground. Some of the most interesting views in the area can be had from the high point of the park, " +
                        "including the North Shore Mountains and the remaining industrial areas of Southeast False Creek. For More Information: [Click Here]";
                url = "https://cfapp.vancouver.ca/ParkFinder_wa/index.cfm?fuseaction=FAC.ParkDetails&park_id=133";
                linkableText(myString, url);
                break;
            case "ndstreet":
                setImage(param);
                blink("Byrne Creek Ravine Park");
                myString = "Circles Byrne Creek. Great forest trail with one section that has 136 stairs, is a great cardio workout. " +
                        "Very forested and is scenic as well as fully protected from sun on a hot day. For More Information: [Click Here]";
                url = "http://www.mapmywalk.com/ca/new-westminster-british-columbia/byrne-creek-ravine-park-route-9683562";
                linkableText(myString, url);
                break;
            case "kinggeorge":
                setImage(param);
                blink("Tynehead Regional Park");
                myString = "Tynehead Regional Park is located just of Highway #1 in Surrey and is a popular park for cycling, picnics, dog walking, or exploring the upper Serpentine River. " +
                        "The area features two sides to the park, the east side called the Serpentine Hills has a perimeter bike trail and the west side has hiking trails and the Serpentine Hatchery. For More Information: [Click Here]";
                url = "http://www.vancouvertrails.com/trails/tynehead-regional-park/";
                linkableText(myString, url);
                break;
            case "surreycentral":
                setImage(param);
                blink("Central City");
                myString = "Central City Shopping Centre is a shopping mall and office tower complex in " +
                        "Whalley, Surrey, British Columbia, Canada, which is owned by Blackwood Partners Management Corporation. For More Information: [Click Here]";
                url = "http://www.centralcity.ca/";
                linkableText(myString, url);
                break;
            case "gateway":
                setImage(param);
                blink("Invergarry Bike Park");
                myString = "Invergarry Park is home to a vast forest and natural area, as well as one of the region's largest downhill mountain bike parks. For More Information: [Click Here]";
                url = "http://www.surrey.ca/culture-recreation/8876.aspx";
                linkableText(myString, url);
                break;
            case "scottroad":
                setImage(param);
                blink("Brownsville Bar Park");
                myString = "Brownsville Bar Park is one of the only locations on the Fraser River with a sandy beach. With 300 metres of waterfront access the park offers great views of " +
                        "New Westminster and the Fraser River. You'll find a walking loop, beach and lots of open green space ideal for a picnic. For More Information: [Click Here]";
                url = "http://www.surrey.ca/culture-recreation/6010.aspx";
                linkableText(myString, url);
                break;
            case "templeton":
                setImage(param);
                blink("McArthurGlen Vancouver");
                myString = "Open since July 2015, McArthurGlen Designer Outlet Vancouver Airport is the first designer outlet in the Vancouver metropolitan area" +
                        "It brings a genuinely new " +
                        "luxury outlet concept with our signature attention to detail, high-quality standards, and exclusive luxury and designer brand mix. For More Information: [Click Here]";
                url = "http://www.mcarthurglen.com/ca/mcarthurglen-vancouver/en/";
                linkableText(myString, url);
                break;
            case "brighouse":
                setImage(param);
                blink("Ling Yen Mountain Temple");
                myString = "The Ling Yen Mountain Temple in Richmond, British Columbia, Canada is a Buddhist monastery, designed by Pacific Rim Architecture in the Chinese palatial style and completed in 1996." +
                        " The temple has about 10,000 members in Greater Vancouver and several dozen resident monastics. For More Information: [Click Here]";
                url = "https://en.wikipedia.org/wiki/Ling_Yen_Mountain_Temple";
                linkableText(myString, url);
                break;
            case "seaisland":
                setImage(param);
                blink("Sea Island");
                myString = "Sea Island is an island in the Fraser River estuary in the city of Richmond, British Columbia. " +
                        "It is located south of the city of Vancouver and north and west of Lulu Island. " +
                        "Sea Island is the home to Vancouver International Airport (YVR), a nature conservation area and a permanent " +
                        "resident population of approximately 736 living in the neighbourhood of Burkeville. A small part of the island is under the administration of the Musqueam Indian Band. For More Information: [Click Here]";
                url = "https://en.wikipedia.org/wiki/Sea_Island_(British_Columbia)";
                linkableText(myString, url);
                break;
            case "lansdowne":
                setImage(param);
                blink("Britannia Shipyards - National Historic Site");
                myString = "A wide variety of programs, events and activities are offered at the Britannia Shipyards National Historic Site. For More Information: [Click Here]";
                url = "http://www.richmond.ca/culture/sites/britannia/about.htm";
                linkableText(myString, url);
                break;
            case "alberdeen":
                setImage(param);
                blink("Quilchena Golf & Country Club");
                myString = "A course of exceptional quality and playability for any level, Quilchena Golf and Country Club offers 120 acreas of golf with five sets of tees allowing for up to 6,665 yards of play. Thanks to Quilchena's westerly location, the course boasts better weather than any other Lower Mainland golf course." +
                        " Great weather combined with well defined fairways and extensive cart paths make for the best playability around - all year round!. For More Information: [Click Here]";
                url = "http://www.qgolfclub.ca/";
                linkableText(myString, url);
                break;
            case "olympic":
                setImage(param);
                blink("Olympic Village");
                myString = "An Olympic Village is an accommodation center built for the Olympic Games, usually within an Olympic Park or elsewhere in a host city. Olympic Villages are built to house all participating athletes, as well as officials and athletic trainers. After the Munich Massacre at the 1972 Olympics, the Villages have been made extremely secure. Only athletes, trainers and officials are allowed to room at the Village, though family members and former Olympic athletes are allowed inside with proper checks. " +
                        "Press and media are also barred.. For More Information: [Click Here]";
                url = "https://en.wikipedia.org/wiki/Olympic_Village";
                linkableText(myString, url);
                break;
            case "gilmore":
                setImage(param);
                blink("Jim Lorimer Park");
                myString = "Jim Lorimer Park in Burnaby was named in James Gibson \"Jim\" Lorimer's honour. James Gibson \"Jim\" Lorimer (June 3, 1923 – October 25, 2012) was a lawyer and political figure in British Columbia. " +
                        "He represented Burnaby-Willingdon in the Legislative Assembly of British Columbia from 1960 to 1975 and from 1979 to 1983 as a New Democratic Party (NDP) member. For More Information: [Click Here]";
                url = "http://www.evergreen.ca/whats-on/event-details/9696/";
                linkableText(myString, url);
                break;
            case "lakecity":
                setImage(param);
                blink("Burnaby Lake Regional Nature Park");
                myString = "This regional park, right in the heart of Burnaby, is a place to reconnect with the natural " +
                        "world without leaving the city. The area is a stunning wildlife sanctuary where birdwatchers regularly spot great blue herons, bald eagles, belted kingfishers, osprey and even rarer birds such as the " +
                        "small green-backed heron.. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/Things-To-Do/Explore-Outdoors/Shorelines---Lakes/Burnaby-Lake-Regional-Nature-Park.html";
                linkableText(myString, url);
                break;
            case "sperling":
                setImage(param);
                blink("Burnaby Village Museum");
                myString = "The Burnaby Village Museum, previously known as the Heritage Village, " +
                        "is an open-air museum in Burnaby, British Columbia, Canada, located at Deer Lake Park. For More Information: [Click Here]";
                url = "http://www.burnabyvillagemuseum.ca/";
                linkableText(myString, url);
                break;
            case "holdom":
                setImage(param);
                blink("Kensington Park");
                myString = "Kensington Park is a large urban park in Burnaby, British Columbia, Canada. It is located between major roads running along its perimeter - " +
                        "Hastings Street, Curtis Street, Kensington Avenue and Holdom Avenue.. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/Things-To-Do/Explore-Outdoors/Parks/Kensington-Park.html";
                linkableText(myString, url);
                break;
            case "brentwood":
                setImage(param);
                blink("Brentwood Town Centre");
                myString = "Brentwood Town Centre (often referred to as Brentwood Mall) is a shopping mall in Burnaby, British Columbia. It is located in the Brentwood Town Centre " +
                        "area of North Burnaby, at the intersection of Willingdon Avenue and the Lougheed Highway, approximately 1.5 kilometres " +
                        "from Vancouver city limits.\n" +
                        "\n" +
                        "Brentwood Mall as it was known opened in 1961 as a partial open air strip centre and enclosed mall. During the Christmas season many Burnaby families bring their young children to the Mall to have their pictures taken with Santa Claus in his workshop.. For More Information: [Click Here]";
                url = "http://www.brentwoodtowncentre.com/index2.asp";
                linkableText(myString, url);
                break;
            case "joycecollingwood":
                setImage(param);
                blink("Swangard Stadium");
                myString = "Swangard Stadium is a multi-purpose stadium in Central Park in Burnaby, British Columbia. Primarily used for soccer, Rugby, football, and athletics, the stadium also used to be home to the " +
                        "Simon Fraser Clan football team and the Vancouver Whitecaps while they were in the Canadian Soccer League (CSL) and various US-based Division 2 leagues. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/City-Services/Rentals-And-Catering/Outdoor-Events/Swangard-Stadium.html";
                linkableText(myString, url);
                break;
            case "productionway":
                setImage(param);
                blink("Burnaby Mountain");
                myString = "Burnaby Mountain, elev. 370 m (1,214 ft), is a low, forested mountain in the city of Burnaby, British Columbia, overlooking the upper arms of Burrard Inlet. It is the location of Simon Fraser University, the Discovery Park research community, " +
                        "and the System Control Tower of BC Hydro and a new complex of residential and commercial development called UniverCity.. For More Information: [Click Here]";
                url = "https://en.wikipedia.org/wiki/Burnaby_Mountain";
                linkableText(myString, url);
                break;
            case "marinedrive":
                setImage(param);
                blink("Fraser River Park");
                myString = "The Fraser River Park is Marpole's favourite park because it is quiet and safe, spacious, natural, used by many different people, is a dog park, has trails, picnic tables, benches, and interesting river activity. For More Information: [Click Here]";
                url = "http://www.marpoleonline.com/fraser-river-park/";
                linkableText(myString, url);
                break;
            case "commercial":
                setImage(param);
                blink("John Hendry Park");
                myString = "John Hendry Park is 27 hectare park in the city of Vancouver, British Columbia, Canada. " +
                        "Trout Lake is located in the center of the park and is operated by the Vancouver Parks Board and the Grandview Community Association. For More Information: [Click Here]";
                url = "https://cfapp.vancouver.ca/parkfinder_wa/index.cfm?fuseaction=FAC.ParkDetails&park_id=85";
                linkableText(myString, url);
                break;
            case "ave":
                setImage(param);
                blink("Slocan Park");
                myString = "Slocan park is enjoyable place to be. Another striking feature in this park is the eagle totem pole standing guard near the skytrain station entrance. For More Information: [Click Here]";
                url = "https://cfapp.vancouver.ca/parkfinder_wa/index.cfm?fuseaction=FAC.ParkDetails&park_id=161/";
                linkableText(myString, url);
                break;
            case "columbia":
                setImage(param);
                blink("Westminster Pier Park");
                myString = "The Westminster Pier Park connects visitors to the mighty Fraser River " +
                        "and when combined with the Waterfront Esplanade Boardwalk creates a magnificent 2.5 km linear waterfront park. For More Information: [Click Here]";
                url = "http://www.newwestpcr.ca/parks/westminster_pier_park.php";
                linkableText(myString, url);
                break;
            case "sapperton":
                setImage(param);
                blink("Sapperton Landing Park");
                myString = "Sapperton Landing Park is a $10M Metro Vancouver regional park funded through the Millennium SkyTrain line development based on City property allocated to Translink. For More Information: [Click Here]";
                url = "http://www.newwestpcr.ca/parks/community_parks/sapperton_landing_park.php";
                linkableText(myString, url);
                break;
            case "braid":
                setImage(param);
                blink("Eagle Quest Golf");
                myString = "At Eagle Quest Golf is fun, and more importantly,  experience is as rewarding as possible, " +
                        "whether you are playing a round of golf, hitting balls, dining in our restaurant or taking a lesson!. For More Information: [Click Here]";
                url = "http://eaglequestgolf.com/locations/coquitlam/";
                linkableText(myString, url);
                break;
            case "lougheed":
                setImage(param);
                blink("Lougheed Town Centre");
                myString = "Lougheed Town Centre is a shopping mall in Burnaby, British Columbia. It is located in the northeast corner of the city, near the border with Coquitlam. For More Information: [Click Here]";
                url = "http://www.lougheedtowncentre.com/";
                linkableText(myString, url);
                break;
            case "royaloak":
                setImage(param);
                blink("Deer Lake Park");
                myString = "Scenic picnic areas & lakeside trails leading to the Burnaby Art Gallery & other attractions. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/things-to-do/explore-outdoors/shorelines---lakes/deer-lake-park.html";
                linkableText(myString, url);
                break;
            case "newwest":
                setImage(param);
                blink("River Market");
                myString = "First opened in 1985 as Westminster Quay Public Market, this 75,000-square-foot marketplace on the Fraser River pioneered a food-led revitalization to become a hub for community life. Today, it showcases 25 of B.C.'s best independent restaurants, shops, and schools all under one roof. For More Information: [Click Here]";
                url = "http://rivermarket.ca//";
                linkableText(myString, url);
                break;
            case "nanaimo":
                setImage(param);
                blink("Vancouver Alpen Club");
                myString = "German community venue that's home to classic cuisine at longtime Deutsches Haus restaurant. For More Information: [Click Here]";
                url = "http://www.vancouveralpenclub.ca/";
                linkableText(myString, url);
                break;
            case "edmonds":
                setImage(param);
                blink("Burnaby Fraser Foreshore Park");
                myString = "n south Burnaby if you're looking for a place for a walk along the water, be sure to check out the Burnaby Fraser Foreshore Park. For More Information: [Click Here]";
                url = "https://www.burnaby.ca/Things-To-Do/Explore-Outdoors/Shorelines---Lakes/Burnaby-Fraser-Foreshore-Park.html";
                linkableText(myString, url);
                break;
        }


    }
    private void setImage(String param)
    {
        ImageView imageview = (ImageView)findViewById(R.id.imgAttraction);

        Context context = imageview.getContext();
        //int id = context.getResources().getIdentifier(param, "attractions", context.getPackageName());
        int id = getResources().getIdentifier("com.douglas.skytrainapp.androidproject:drawable/" + param, null, null);
        imageview.setBackgroundResource(id);
    }
    private void linkableText(String text, final String url)
    {
        TextView txtInfo = (TextView) findViewById(R.id.txtAttraction);
        int i1 = text.indexOf("[");
        int i2 = text.indexOf("]");
        txtInfo.setMovementMethod(LinkMovementMethod.getInstance());
        txtInfo.setText(text, TextView.BufferType.SPANNABLE);
        Spannable mySpannable = (Spannable)txtInfo.getText();
        ClickableSpan myClickableSpan = new ClickableSpan()
        {
            @Override
            public void onClick(View widget) {
                Uri uri = Uri.parse(url);
                Intent intent = new Intent(Intent.ACTION_VIEW, uri);
                startActivity(intent);
            }
        };
        mySpannable.setSpan(myClickableSpan, i1, i2 + 1, Spannable.SPAN_EXCLUSIVE_EXCLUSIVE);
    }
    private void blink(String param){
        TextView txtName = (TextView) findViewById(R.id.txtToolBar);
        txtName.setText(param);
        Animation anim = new AlphaAnimation(0.0f, 1.0f);
        anim.setDuration(600); //You can manage the time of the blink with this parameter
        anim.setStartOffset(20);
        anim.setRepeatMode(Animation.REVERSE);
        anim.setRepeatCount(Animation.INFINITE);
        txtName.startAnimation(anim);
        /*final Handler handler = new Handler();
        new Thread(new Runnable() {
            @Override
            public void run() {
                int timeToBlink = 1000;    //in milissegunds
                try{Thread.sleep(timeToBlink);}catch (Exception e) {}
                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        TextView txt = (TextView) findViewById(R.id.txtName);
                        if(txt.getVisibility() == View.VISIBLE){
                            txt.setVisibility(View.INVISIBLE);
                        }else{
                            txt.setVisibility(View.VISIBLE);
                        }
                        blink();
                    }
                });
            }
        }).start();*/
    }
}
