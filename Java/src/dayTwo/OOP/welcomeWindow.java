package dayTwo.OOP;


import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by student on 24-Aug-16.
 */

public class welcomeWindow extends JFrame {
    private JPanel contentPane;
    private JButton enterBtn;
    private JLabel welcomeLbl;


    public welcomeWindow() {
        setTitle("Welcome Frame");
        setSize(800, 400);
        setResizable(false);

        // Centers the frame 1) bad method 2) good method
        // setLocation(null);
        Dimension d = getToolkit().getScreenSize();
        setLocation(d.width/2 - getWidth()/2, d.height/2 - getHeight()/2);

        // Cleans unneeded information
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        // set border is empty if not required
        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

        // Just plain and clean panel
        setContentPane(contentPane);
        contentPane.setLayout(null);

        // The parameter in constructor is a label
        enterBtn = new JButton("Enter");
        enterBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // Go to main frame
                mainWindow mainFrame = new mainWindow();
            }
        });

        enterBtn.setBounds(360, 200, 70, 25);
        contentPane.add(enterBtn);

        welcomeLbl = new JLabel("Welcome to Employee Program!");
        welcomeLbl.setForeground(Color.BLACK);
        welcomeLbl.setFont(new Font("Verdana", Font.BOLD | Font.ITALIC, 20));
        welcomeLbl.setBounds(220, 80, 400, 100);
        contentPane.add(welcomeLbl);

        setVisible(true);

    }
}

