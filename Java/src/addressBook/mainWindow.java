package addressBook;

import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.border.TitledBorder;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.util.List;

import static addressBook.contactGenerator.contacts;

/**
 * Created by student on 25-Aug-16.
 */
public class mainWindow implements ActionListener {

    private JLabel firstNameLbl, lastNameLbl, dobLbl;

    private JLabel lineOneLbl, lineTwoLbl, townLbl, countyLbl, postcodeLbl;

    private JLabel phoneLbl, mobileLbl, emailLbl, facebookLbl, twitterLbl;

    private JTextField firstNameTxt, lastNameTxt, dobTxt;

    private JTextField lineOneTxt, lineTwoTxt, townTxt, countyTxt, postcodeTxt;

    private JTextField phoneTxt, mobileTxt, emailTxt, facebookTxt, twitterTxt;

    private JButton updateBtn, removeBtn;

    private JMenu fileMenu, editMenu;

    private JMenuItem newMenuItem, exitMenuItem, searchMenuItem;

    private JMenuBar menuBar;

    private JPanel content, listPanel, fieldPanel, inputPanel, btnPanel;

    private JList conList;
    private int conIndex = -1;
    private boolean createNew;

    public mainWindow() {

        JFrame mainFrame = new JFrame("Contacts List");
        mainFrame.setSize(800, 450);
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


        mainFrame.addWindowListener(c);

        Dimension d = mainFrame.getToolkit().getScreenSize();
        mainFrame.setLocation(d.width/2 - mainFrame.getWidth()/2, d.height/2 - mainFrame.getHeight()/2);

        mainFrame.setJMenuBar(createMenu());

        content = (JPanel) mainFrame.getContentPane();
        content.setLayout(new GridLayout(1, 2 , 5, 5));

        prepareJList();

        listPanel = new JPanel();
        listPanel.setBorder(new EtchedBorder(EtchedBorder.LOWERED));
        JScrollPane scrollPane = new JScrollPane(createContactList());
        scrollPane.setPreferredSize(new Dimension(380, 335));
        listPanel.add(scrollPane);
        listPanel.setVisible(false);
        content.add(listPanel);


        fieldPanel = new JPanel();
        TitledBorder title;
        title = BorderFactory.createTitledBorder("Employee's Details");
        fieldPanel.setBorder(title);
        fieldPanel.add(createFieldsPanel(), BorderLayout.CENTER);
        fieldPanel.add(createBtnPanel(), BorderLayout.SOUTH);
        fieldPanel.setVisible(false);
        content.add(fieldPanel);

        mainFrame.setVisible(true);

    }

    private JMenuBar createMenu() {
        menuBar = new JMenuBar();

        fileMenu = new JMenu("File");
        fileMenu.setMnemonic(KeyEvent.VK_F);

        newMenuItem = new JMenuItem("New");
        newMenuItem.setMnemonic(KeyEvent.VK_N);
        newMenuItem.addActionListener(this);
        fileMenu.add(newMenuItem);

        exitMenuItem = new JMenuItem("Exit");
        exitMenuItem.setMnemonic(KeyEvent.VK_E);
        exitMenuItem.addActionListener(this);
        fileMenu.add(exitMenuItem);

        menuBar.add(fileMenu);

        editMenu = new JMenu("Edit");
        fileMenu.setMnemonic(KeyEvent.VK_D);

        searchMenuItem = new JMenuItem("Search");
        searchMenuItem.setMnemonic(KeyEvent.VK_S);
        searchMenuItem.addActionListener(this);
        editMenu.add(searchMenuItem);

        menuBar.add(editMenu);

        return menuBar;
    }

    private JList createContactList() {

        DefaultListModel listModel = new DefaultListModel();

        if (contacts.size() > 0){
            for (Contact c : contacts){
                listModel.addElement(c);
            }
        }
        conList.setModel(listModel);
        return conList;
    }

    private void prepareJList(){
        conList = new JList();
        conList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        conList.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                conIndex = conList.getSelectedIndex();
                if (contacts.size() > 0 && conIndex != -1) {
                    loadConFields(conIndex);
                }
                else {
                    clearTextFields();
                }
            }
        });
    }

    private JPanel createFieldsPanel() {
        inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(0, 2, 5, 5));

        firstNameLbl = new JLabel("First Name: ");
        inputPanel.add(firstNameLbl);
        firstNameTxt = new JTextField();
        inputPanel.add(firstNameTxt);

        lastNameLbl = new JLabel("Last Name: ");
        inputPanel.add(lastNameLbl);
        lastNameTxt = new JTextField();
        inputPanel.add(lastNameTxt);

        dobLbl = new JLabel("Date of Birth (YYYY-MM-DD): ");
        inputPanel.add(dobLbl);
        dobTxt = new JTextField();
        inputPanel.add(dobTxt);

        lineOneLbl = new JLabel("First Address Line: ");
        inputPanel.add(lineOneLbl);
        lineOneTxt = new JTextField();
        inputPanel.add(lineOneTxt);

        lineTwoLbl = new JLabel("Second Address Line ");
        inputPanel.add(lineTwoLbl);
        lineTwoTxt = new JTextField();
        inputPanel.add(lineTwoTxt);

        townLbl = new JLabel("Town: ");
        inputPanel.add(townLbl);
        townTxt = new JTextField();
        inputPanel.add(townTxt);

        countyLbl = new JLabel("County: ");
        inputPanel.add(countyLbl);
        countyTxt = new JTextField();
        inputPanel.add(countyTxt);

        postcodeLbl = new JLabel("Postcode: ");
        inputPanel.add(postcodeLbl);
        postcodeTxt = new JTextField();
        inputPanel.add(postcodeTxt);

        phoneLbl = new JLabel("Home Number: ");
        inputPanel.add(phoneLbl);
        phoneTxt = new JTextField();
        inputPanel.add(phoneTxt);

        mobileLbl = new JLabel("Mobile Number: ");
        inputPanel.add(mobileLbl);
        mobileTxt = new JTextField();
        inputPanel.add(mobileTxt);

        emailLbl = new JLabel("E-mail Address: ");
        inputPanel.add(emailLbl);
        emailTxt = new JTextField();
        inputPanel.add(emailTxt);

        facebookLbl = new JLabel("Facebook ID: ");
        inputPanel.add(facebookLbl);
        facebookTxt = new JTextField();
        inputPanel.add(facebookTxt);

        twitterLbl = new JLabel("Twitter ID: ");
        inputPanel.add(twitterLbl);
        twitterTxt = new JTextField();
        inputPanel.add(twitterTxt);

        return inputPanel;
    }

    private JPanel createBtnPanel() {
        btnPanel = new JPanel();
        btnPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));

        updateBtn = new JButton("Update");
        updateBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (createNew && conList.isSelectionEmpty()) {
                    Processor.addNewContact(getFieldsInfo());
                    createContactList();
                    clearTextFields();
                }
                else {
                    Processor.editContact(conIndex, getFieldsInfo());
                    createContactList();
                }
                createNew = false;
                conIndex = -1;
            }
        });
        btnPanel.add(updateBtn);

        /*newBtn = new JButton("New");
        newBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (createNew && conList.isSelectionEmpty()) {
                    Processor.addNewContact(getFieldsInfo());
                    createContactList();
                    clearTextFields();
                }
                createNew = false;
                conIndex = -1;
            }
        });
        btnPanel.add(newBtn);

        updateBtn = new JButton("Update");
        updateBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (!createNew) {
                    Processor.editContact(conIndex, getFieldsInfo());
                    createContactList();
                }
                createNew = false;
                conIndex = -1;
            }
        });
        btnPanel.add(updateBtn);*/

        removeBtn = new JButton("Remove");
        removeBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (conIndex >= 0){
                    Processor.removeContact(conIndex);
                    clearTextFields();
                    createContactList();
                    conIndex = -1;
                }
                else {
                    JOptionPane.showMessageDialog(null, "Please select a contact.");
                }
            }
        });
        btnPanel.add(removeBtn);

        return btnPanel;
    }

    private void loadConFields(int index) {

        firstNameTxt.setText(contacts.get(index).getFirstName());
        lastNameTxt.setText(contacts.get(index).getLastName());
        dobTxt.setText(contacts.get(index).getBirthDate().toString());

        lineOneTxt.setText(contacts.get(index).getAddress().getLineOne());
        lineTwoTxt.setText(contacts.get(index).getAddress().getLineTwo());
        townTxt.setText(contacts.get(index).getAddress().getTown());
        countyTxt.setText(contacts.get(index).getAddress().getCounty());
        postcodeTxt.setText(contacts.get(index).getAddress().getPostcode());

        phoneTxt.setText(contacts.get(index).getPhoneNumber());
        mobileTxt.setText(contacts.get(index).getMobileNumber());
        emailTxt.setText(contacts.get(index).getEmail());
        facebookTxt.setText(contacts.get(index).getFacebook());
        twitterTxt.setText(contacts.get(index).getTwitter());

    }

    private void clearTextFields() {

        firstNameTxt.setText("");
        lastNameTxt.setText("");
        dobTxt.setText("");

        lineOneTxt.setText("");
        lineTwoTxt.setText("");
        townTxt.setText("");
        countyTxt.setText("");
        postcodeTxt.setText("");

        phoneTxt.setText("");
        mobileTxt.setText("");
        emailTxt.setText("");
        facebookTxt.setText("");
        twitterTxt.setText("");

    }

    private List<String> getFieldsInfo() {

        List<String> data = new ArrayList<>();

        data.add(firstNameTxt.getText());
        data.add(lastNameTxt.getText());
        String[] dobData = dobTxt.getText().split("-");
        data.add(dobData[0]);
        data.add(dobData[1]);
        data.add(dobData[2]);

        data.add(lineOneTxt.getText());
        data.add(lineTwoTxt.getText());
        data.add(townTxt.getText());
        data.add(countyTxt.getText());
        data.add(postcodeTxt.getText());

        data.add(phoneTxt.getText());
        data.add(mobileTxt.getText());
        data.add(emailTxt.getText());
        data.add(facebookTxt.getText());
        data.add(twitterTxt.getText());

        return data;
    }


    @Override
    public void actionPerformed(ActionEvent e) {

        String action = e.getActionCommand();

        if ("New".equals(action)) {
            clearTextFields();
            if (conIndex < 0) { createNew = true; }
            listPanel.setVisible(true);
            fieldPanel.setVisible(true);
        }
        else if ("Exit".equals(action)) {
            System.exit(0);
        }
        else if ("Search".equals(action)) {
            String search = JOptionPane.showInputDialog("Enter first name of Contact: ");
            conIndex = Processor.searchContact(search);

            if (conIndex != -1) {
                loadConFields(conIndex);
                JOptionPane.showMessageDialog(null, "Contact was found!");
                fieldPanel.setVisible(true);
                listPanel.setVisible(true);
            }
            else {
                JOptionPane.showMessageDialog(null, "Contact could not be found!");
            }

        }
    }
}
