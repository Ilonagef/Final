package Process;
import java.io.PrintWriter;
import java.io.StringWriter;





public class JException {

	public static String getTrace(Throwable e) {
		// TODO Auto-generated catch block
		StringWriter sw = new StringWriter();
		PrintWriter pw = new PrintWriter(sw);
		e.printStackTrace(pw);
		
		return pw.toString();
	}
}
