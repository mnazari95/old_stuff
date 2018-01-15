package InvestmentCalc;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class InvestmentCalcGUI 
extends JFrame
implements ActionListener
{

	//fields
	private final int WIDTH = 350;
	private final int HEIGHT = 175;
	
	private JLabel label = new JLabel("Inital Investment: ");
	private JLabel label2 = new JLabel("Monthly Savings: ");
	private JLabel label3 = new JLabel("Annual Interest Rate: ");
	private JLabel label4 = new JLabel("Years: ");
	private JLabel label5 = new JLabel("Interest added:");
	
	private JTextField textBox = new JTextField();
	private JTextField textBox2 = new JTextField();
	private JTextField textBox3 = new JTextField();
	private JTextField textBox4 = new JTextField();
	
	private JRadioButton monthly = new JRadioButton("monthly");
	private JRadioButton annually = new JRadioButton("annually");
	
	private JButton calculateButton = new JButton("Calculate");
	private JButton resetButton = new JButton("Reset");
	private JButton exitButton = new JButton("Exit");
	
	private JPanel leftPanel = new JPanel(new GridLayout(4,1));
	private JPanel centerPanel = new JPanel(new GridLayout(4,1));
	private JPanel rightPanel = new JPanel(new GridLayout(3,1));
	private JPanel bottomPanel = new JPanel(new GridLayout(1,3));
	private ButtonGroup group = new ButtonGroup();
	private Container con = getContentPane();
	
	private double investment = 0;
	private double monthlySaving = 0;
	private double interestRate = 0;
	private int years = 0;
	private double finalResult = 0;
	
	//constructor
	public InvestmentCalcGUI()
	{
		super("Investment Calculator");
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		con.setLayout(new BorderLayout());
		
		con.add(leftPanel, BorderLayout.WEST);
		con.add(centerPanel, BorderLayout.CENTER);
		con.add(rightPanel, BorderLayout.EAST);
		con.add(bottomPanel, BorderLayout.SOUTH);
		
		leftPanel.add(label);
		leftPanel.add(label2);
		leftPanel.add(label3);
		leftPanel.add(label4);
		
		centerPanel.add(textBox);
		centerPanel.add(textBox2);
		centerPanel.add(textBox3);
		centerPanel.add(textBox4);
		
		group.add(monthly);
		group.add(annually);
		
		rightPanel.add(label5);
		rightPanel.add(monthly);
		rightPanel.add(annually);
		
		bottomPanel.add(calculateButton);
		bottomPanel.add(resetButton);
		bottomPanel.add(exitButton);
		
		calculateButton.addActionListener(this);
		resetButton.addActionListener(this);
		exitButton.addActionListener(this);
		
		setSize(WIDTH, HEIGHT);
	}

	public void actionPerformed(ActionEvent arg0) 
	{
		Object source = arg0.getSource();
		String iniInvestment = "",
				monthlySavingData = "",
				interestRate = "",
				years = "";
		
		if(source == calculateButton)
		{
			//local fields
			double tempInvestment = 0;
			
			//translate input into data
			iniInvestment = textBox.getText();
			monthlySavingData = textBox2.getText();
			interestRate = textBox3.getText();
			years = textBox4.getText();
			
			investment = Double.parseDouble(iniInvestment);
			monthlySaving = Double.parseDouble(monthlySavingData);
			this.interestRate = Double.parseDouble(interestRate);
			this.years = Integer.parseInt(years);
			
			tempInvestment = investment;
			
			//calculate monthly
			if(monthly.isSelected())
			{
				//transferring years into months
				int numbOfMonth = this.years * 12;
				
				for(int i = 0; i < numbOfMonth; i++)
				{
					tempInvestment = tempInvestment + (tempInvestment * this.interestRate/(12*100)) + monthlySaving; 
				}
				finalResult = tempInvestment;
			}
			
			//calculate annually
			if(annually.isSelected())
			{
				
				for(int i = 0; i < this.years; i++)
				{
					tempInvestment = tempInvestment + (tempInvestment * this.interestRate/100) + 12 *monthlySaving;
				}
				finalResult = tempInvestment;
			}
			//round result
			finalResult = Math.round(finalResult*100.0)/100.0;
			
			//show result
			JOptionPane.showMessageDialog(null, "Resulting amount: $" + finalResult);
		}
		else if(source == resetButton)
		{
			textBox.setText("");
			textBox2.setText("");
			textBox3.setText("");
			textBox4.setText("");
			
			//reset the interest
			investment = 0;
			monthlySaving = 0;
			this.interestRate = 0;
			this.years = 0;
			finalResult = 0;
			
		}
		else if(source == exitButton)
		{
			//close program
			System.exit(0);
		}
		
	}
	
}
