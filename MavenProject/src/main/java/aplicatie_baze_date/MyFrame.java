package aplicatie_baze_date;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import java.awt.BorderLayout;
import javax.swing.JToolBar;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.awt.event.ActionEvent;

public class MyFrame extends JFrame {

	ResultSet rs;
	private JPanel contentPane;
	private JTextField textField;
	private JTextField txtID;
	private JTextField txtNume;
	private JTextField txtVarsta;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MyFrame frame = new MyFrame();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 * @throws SQLException 
	 */
	public MyFrame() throws SQLException {
		String url = "jdbc:mysql://localhost:3306/baza_date";
		Connection con = DriverManager.getConnection(url,"root","root");
		String sql_select = "SELECT *FROM persoane";
		java.sql.Statement st = con.createStatement();
		rs = st.executeQuery(sql_select);
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(0, 0));
		
		JToolBar toolBar = new JToolBar();
		contentPane.add(toolBar, BorderLayout.NORTH);
		
		JButton btnNewButton = new JButton("<<");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					rs.first();
					txtID.setText(Integer.toString(rs.getInt("ID")));
					txtNume.setText(rs.getString("nume"));
					txtVarsta.setText(Integer.toString(rs.getInt("varsta")));
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		toolBar.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("<");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					rs.previous();
					txtID.setText(Integer.toString(rs.getInt("ID")));
					txtNume.setText(rs.getString("nume"));
					txtVarsta.setText(Integer.toString(rs.getInt("varsta")));
				} catch (SQLException e1) {
					JOptionPane.showMessageDialog(null, "Nu exista element anterior!");
				}
			}
		});
		toolBar.add(btnNewButton_1);
		
		textField = new JTextField();
		toolBar.add(textField);
		textField.setColumns(10);
		
		JButton btnNewButton_2 = new JButton(">");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					rs.next();
					txtID.setText(Integer.toString(rs.getInt("ID")));
					txtNume.setText(rs.getString("nume"));
					txtVarsta.setText(Integer.toString(rs.getInt("varsta")));
				} catch (SQLException e1) {
					JOptionPane.showMessageDialog(null, "Sfarsit de informatii!");
				}
			}
		});
		toolBar.add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton(">>");
		btnNewButton_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					rs.last();
					txtID.setText(Integer.toString(rs.getInt("ID")));
					txtNume.setText(rs.getString("nume"));
					txtVarsta.setText(Integer.toString(rs.getInt("varsta")));
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		toolBar.add(btnNewButton_3);
		
		JButton btnNewButton_4 = new JButton("Add");
		btnNewButton_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String url = "jdbc:mysql://localhost:3306/baza_date";
					Connection con = DriverManager.getConnection(url,"root","root");
					
					String sql_insert = "INSERT INTO persoane VALUES(?,?,?)";
					
					int id = Integer.parseInt(txtID.getText());
					String nume = txtNume.getText();
					int varsta = Integer.parseInt(txtVarsta.getText());
					
					java.sql.PreparedStatement ps = con.prepareStatement(sql_insert);
					
					ps.setInt(1, id);
					ps.setString(2, nume);
					ps.setInt(3, varsta);
					
					ps.executeUpdate();
					JOptionPane.showMessageDialog(null,"Informatie inserata cu succes!");
				} catch (SQLException e1) {
					JOptionPane.showMessageDialog(null, "Nu sunt permise informatii duplicate!");
				} catch(NumberFormatException e2) {
					JOptionPane.showMessageDialog(null, "Introduceti corect informatiile!");
				}
				
			}
		});
		toolBar.add(btnNewButton_4);
		
		JButton btnNewButton_5 = new JButton("Del");
		btnNewButton_5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String url = "jdbc:mysql://localhost:3306/baza_date";
					Connection con = DriverManager.getConnection(url,"root","root");
					java.sql.Statement st = con.createStatement();
					
					int id = Integer.parseInt(txtID.getText());
					String nume = txtNume.getText();
					int varsta = Integer.parseInt(txtVarsta.getText());
					
					String sql_delete = "DELETE FROM persoane WHERE id = '"+id+"'";
					
					st.executeUpdate(sql_delete);
					
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		toolBar.add(btnNewButton_5);
		
		JButton btnNewButton_6 = new JButton("Upd");
		btnNewButton_6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String url = "jdbc:mysql://localhost:3306/baza_date";
					Connection con = DriverManager.getConnection(url,"root","root");
					java.sql.Statement st = con.createStatement();
					
					int id = Integer.parseInt(txtID.getText());
					String nume = txtNume.getText();
					int varsta = Integer.parseInt(txtVarsta.getText());
					
					String sql_update = "UPDATE persoane SET nume='"+nume+"',varsta='"+varsta+"' WHERE id='"+id+"'";
					
					st.executeUpdate(sql_update);
					
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		toolBar.add(btnNewButton_6);
		
		JButton btnNewButton_7 = new JButton("Clc");
		btnNewButton_7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtID.setText("");
				txtNume.setText("");
				txtVarsta.setText("");
			}
		});
		toolBar.add(btnNewButton_7);
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("ID");
		lblNewLabel.setBounds(134, 73, 45, 13);
		panel.add(lblNewLabel);
		
		txtID = new JTextField();
		txtID.setBounds(214, 70, 96, 19);
		panel.add(txtID);
		txtID.setColumns(10);
		
		txtNume = new JTextField();
		txtNume.setBounds(214, 96, 96, 19);
		txtNume.setColumns(10);
		panel.add(txtNume);
		
		JLabel lblNume = new JLabel("Nume");
		lblNume.setBounds(121, 99, 45, 13);
		panel.add(lblNume);
		
		txtVarsta = new JTextField();
		txtVarsta.setBounds(214, 125, 96, 19);
		txtVarsta.setColumns(10);
		panel.add(txtVarsta);
		
		JLabel lblVarsta = new JLabel("Varsta");
		lblVarsta.setBounds(121, 128, 45, 13);
		panel.add(lblVarsta);
		
		
		rs.first();
		txtID.setText(Integer.toString(rs.getInt("ID")));
		txtNume.setText(rs.getString("nume"));
		txtVarsta.setText(Integer.toString(rs.getInt("varsta")));
		
	}
}
