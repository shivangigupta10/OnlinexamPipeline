Added here
public void windowDeiconified(WindowEvent e) {  }
public void windowClosing(WindowEvent e) {   System.exit(0); }

<%
	String redirectURL = "http://www.example.com/";
public void windowDeiconified(WindowEvent e) {  }
public void windowClosing(WindowEvent e) {   System.exit(0); }
	response.sendRedirect(redirectURL);
	response.sendForward(redirectURL);
	return;
%>
 
 
