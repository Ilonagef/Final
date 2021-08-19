package process_test_package;

import static org.junit.jupiter.api.Assertions.*;

import java.io.PrintWriter;
import java.io.StringWriter;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import Process.JException;



class BasicTest {

	@BeforeAll
	static void setUpBeforeClass() throws Exception {
	}

	@AfterAll
	static void tearDownAfterClass() throws Exception {
	}

	@BeforeEach
	void setUp() throws Exception {
	}

	@AfterEach
	void tearDown() throws Exception {
	}

	@Test
	void test1() {
		try {
			System.out.print("Test1\n");
		}catch(Exception e){
			fail("Test1 failed");
		}
	}
	@Test
	void test2() {
		try {
			System.out.print("Test2\n");
		}catch(Exception e){
			fail("Test2 failed");
		}
	}
	@Test
	void test3() {
		try {
			System.out.print("Test3\n");
			Assertions.assertTrue(5>2);
		}catch(Exception e){
			fail("Test3 failed");
		}
	}
}
