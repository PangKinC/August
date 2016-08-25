package dayTwo.OOP;

import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.border.TitledBorder;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.awt.*;
import java.awt.event.*;

import static dayTwo.OOP.peopleGenerator.people;

import java.util.ArrayList;
import java.util.List;


/**
 * Created by student on 24-Aug-16.
 */
public class mainWindow implements ActionListener {

    // fields
    private JLabel firstNameLbl;
    private JLabel lastNameLbl;
    private JLabel weightLbl;
    private JLabel heightLbl;
    private JLabel dobLbl;
    private JLabel sexLbl;
    private JLabel posLbl;
    private JLabel hireLbl;

    private JTextField firstNameTxt;
    private JTextField lastNameTxt;
    private JTextField weightTxt;
    private JTextField heightTxt;
    private JTextField dobTxt;
    private JTextField sexTxt;
    private JTextField posTxt;
    private JTextField hireTxt;

    private JButton updateBtn;
    private JButton removeBtn;

    private JMenuBar menuBar;
    private JMenu fileMenu;
    private JMenu editMenu;
    private JMenuItem newMenuItem, exitMenuItem, indexMenuItem;

    private JPanel content;
    private JPanel listPanel;
    private JPanel fieldPanel;
    private JPanel inputPanel;
    private JPanel btnPanel;

    private JList empList;
    private int empIndex = -1;
    private boolean createNew;

    // Constructor

    public mainWindow() {
        JFrame mainFrame = new JFrame("Employee Database");
        mainFrame.setSize(800, 400);
        mainFrame.setResizable(false);

        mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        WindowListener l  = new WindowAdapter() {
            public void windowClosing(WindowEvent e){
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

        mainFrame.addWindowListener(l);

        mainFrame.setJMenuBar(createMenu());

        content = (JPanel) mainFrame.getContentPane();
        content.setLayout(new GridLayout(1, 2, 5, 5));

        prepareJList();

        listPanel = new JPanel();
        listPanel.setBorder(new EtchedBorder(EtchedBorder.LOWERED));
        JScrollPane scrollPane = new JScrollPane(createEmpList());
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

        // File Menu

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

        indexMenuItem = new JMenuItem("Search");
        indexMenuItem.setMnemonic(KeyEvent.VK_S);
        indexMenuItem.addActionListener(this);
        editMenu.add(indexMenuItem);

        menuBar.add(editMenu);

        return menuBar;
    }

    private void prepareJList() {
        empList = new JList();
        empList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        empList.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                empIndex = empList.getSelectedIndex();
                if (people.size() > 0 && empIndex != -1 ) {
                    loadEmpFields(empIndex);
                }
                else {
                    clearTxtFields();
                }
            }
        });
    }


    private JList createEmpList() {

        DefaultListModel listModel = new DefaultListModel();

        if (people.size() > 0){
            for (Employee e : people) {
                listModel.addElement(e);
            }
        }
        empList.setModel(listModel);
        return empList;

    }

    private JPanel createFieldsPanel() {
        inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(0, 2, 5, 5));

        firstNameLbl = new JLabel("First Name:" );
        inputPanel.add(firstNameLbl);
        firstNameTxt = new JTextField();
        inputPanel.add(firstNameTxt);

        lastNameLbl = new JLabel("Last Name:" );
        inputPanel.add(lastNameLbl);
        lastNameTxt= new JTextField();
        inputPanel.add(lastNameTxt);

        weightLbl = new JLabel("Weight" );
        inputPanel.add(weightLbl);
        weightTxt = new JTextField();
        inputPanel.add(weightTxt);

        heightLbl = new JLabel("Height:" );
        inputPanel.add(heightLbl);
        heightTxt = new JTextField();
        inputPanel.add(heightTxt);

        dobLbl = new JLabel("D.O.B (YYYY-MM-DD):" );
        inputPanel.add(dobLbl);
        dobTxt = new JTextField();
        inputPanel.add(dobTxt);

        sexLbl = new JLabel("Gender (M / F): " );
        inputPanel.add(sexLbl);
        sexTxt = new JTextField();
        inputPanel.add(sexTxt);

        posLbl = new JLabel("Position:" );
        inputPanel.add(posLbl);
        posTxt = new JTextField();
        inputPanel.add(posTxt);

        hireLbl = new JLabel("Hire Date (YYYY-MM-DD): ");
        inputPanel.add(hireLbl);
        hireTxt = new JTextField();
        inputPanel.add(hireTxt);

        return inputPanel;
    }

    private JPanel createBtnPanel() {
        btnPanel = new JPanel();
        btnPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));
        updateBtn = new JButton("Update");
        updateBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (createNew && empList.isSelectionEmpty()) {
                    taskProcessing.createEmployee(getFieldsInfo());
                    createEmpList();
                    clearTxtFields();
                }
                else {
                    taskProcessing.editDetails(empIndex, getFieldsInfo());
                    createEmpList();
                }
                createNew = false;
                empIndex = -1;
            }
        });

        btnPanel.add(updateBtn);

        removeBtn = new JButton("Remove");
        removeBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (empIndex >= 0) {
                    taskProcessing.removeEmployee(empIndex);
                    clearTxtFields();
                    createEmpList();
                    empIndex = -1;
                } else {
                    JOptionPane.showMessageDialog(null, "No Employee selected.");
                }
            }

        });
        btnPanel.add(removeBtn);

        return btnPanel;
    }

    @Override
    public void actionPerformed(ActionEvent e) {

        String action = e.getActionCommand();

        if ("New".equals(action)) {
            clearTxtFields();
            if (empIndex < 0)
                createNew = true;
            listPanel.setVisible(true);
            fieldPanel.setVisible(true);
        }
        else if ("Exit".equals(action)){
            System.exit(0);
        }
        else if ("Search".equals(action)) {
            String search = JOptionPane.showInputDialog("Enter first name: ");
            empIndex = taskProcessing.searchPerson(search);

            if(empIndex != -1){
                loadEmpFields(empIndex);
                fieldPanel.setVisible(true);
                listPanel.setVisible(true);
            }
            else {
                JOptionPane.showMessageDialog(null, "Cannot find that Employee!");
            }
        }

    }

    private void clearTxtFields(){

        firstNameTxt.setText("");
        lastNameTxt.setText("");
        weightTxt.setText("");
        heightTxt.setText("");
        dobTxt.setText("");
        sexTxt.setText("");
        posTxt.setText("");
        hireTxt.setText("");
        createNew = true;
    }

    private void loadEmpFields(int index) {

        firstNameTxt.setText(people.get(index).getFirstName());
        lastNameTxt.setText(people.get(index).getLastName());
        heightTxt.setText(Short.toString(people.get(index).getHeight()));
        weightTxt.setText(Double.toString(people.get(index).getWeight()));
        dobTxt.setText(people.get(index).getBirthDate().toString());
        sexTxt.setText(people.get(index).getSex().toString());
        posTxt.setText(people.get(index).getPosition());
        hireTxt.setText(people.get(index).getHireDate().toString());

    }

    private List<String> getFieldsInfo() {

        List<String> data = new ArrayList<>();

        data.add(firstNameTxt.getText());
        data.add(lastNameTxt.getText());
        data.add(heightTxt.getText());
        data.add(weightTxt.getText());

        String[] dobData = dobTxt.getText().split("-");
        data.add(dobData[0]);
        data.add(dobData[1]);
        data.add(dobData[2]);

        data.add(sexTxt.getText());
        data.add(posTxt.getText());

        String[] hireData = hireTxt.getText().split("-");
        data.add(hireData[0]);
        data.add(hireData[1]);
        data.add(hireData[2]);

        return data;
    }

}
