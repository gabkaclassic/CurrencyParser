package com.gab.Server.entity;

import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

import java.time.LocalDate;

@Document("curse")
@Data
@NoArgsConstructor
public class Curse {
    
    @Id
    private String id;
    
    private LocalDate date;
    
    private String jsonData;
    
    public Curse(String json) {
        
        String date =
                json.lines()
                .filter(line -> line.contains("\"Date\""))
                .map(line -> line.split("\"Date\": ")[1])
                .findFirst().orElse("");
        setDate(date);
        
        setJsonData(json);
    }
    
    public void setDate(String value) {
    

        value = value.trim()
                .substring(value.indexOf("\"")+1, Math.min(value.lastIndexOf("\""), 11));
        System.out.println(value);
        date = LocalDate.parse(value);
    }
}
