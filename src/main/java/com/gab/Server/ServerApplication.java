package com.gab.Server;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.ComponentScans;
import org.springframework.context.annotation.PropertySource;
import org.springframework.context.annotation.PropertySources;
import org.springframework.scheduling.annotation.EnableScheduling;

@SpringBootApplication
@EnableScheduling
@ComponentScans(
				@ComponentScan("com.gab.Server")
)
@PropertySources({
		@PropertySource("classpath:application.properties")
})
public class ServerApplication {

	public static void main(String[] args) {
		
		SpringApplication.run(ServerApplication.class, args);
	}
	
}