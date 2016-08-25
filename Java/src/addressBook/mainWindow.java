package addressBook;

import javax.swing.*;
import java.awt.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;

/**
 * Created by student on 25-Aug-16.
 */
public class mainWindow {

    private JLabel firstNameLbl, lastNameLbl, dobLbl;

    private JLabel lineOneLbl, ineTwoLbl, townLbl, countyLbl, postcodeLbl;

    private JLabel phoneLbl, mobileLbl, emailLbl, facebookLbl, twitterLbl;

    private JTextField firstNameTxt, lastNameTxt, dobTxt;

    private JTextField lineOneTxt, ineTwoTxt, townTxt, countyTxt, postcodeTxt;

    private JTextField phoneTxt, mobileTxt, emailTxt, facebookTxt, twitterTxt;

    private JButton updateBtn, removeBtn;

    private JMenu fileMenu, editMenu;

    private JMenuItem newMenuItem, exitMenuItem, searchMenuItem;

    private JMenuBar menuBar;

    private JPanel content, listPanel, fieldPanel, inputPanel, btnPanel;

    private JList empList;
    private int empIndex;
    private boolean createNew;

    public mainWindow() {

        JFrame mainFrame = new JFrame("Contacts List");
        mainFrame.setSize(800, 400);
        mainFrame.setResizable(false);

        mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        WindowListener c = new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                int confirm = JOptionPane.showOptionDialog(mainFrame,
                        "Are you sure you want to Exit?", "Exit Confirmation",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE,
                        null, null, null);

                if (confirm == 0) {
                    mainFrame.dispose();
                    System.exit(0);
                }
            }
        };

        Dimension d = mainFrame.getToolkit().getScreenSize();
        mainFrame.setLocation(d.width/2 - mainFrame.getWidth()/2, d.height/2 - mainFrame.getHeight()/2);
        mainFrame.addWindowListener(c);

        //mainFrame.setJMenuBar(createMenu());

        content = (JPanel)mainFrame.getContentPane();
        content.setLayout(new GridLayout(1, 2 , 5, 5));



    }

    /*private JMenuBar createMenu() {
    }*/


}
