package com.gab.Server.repositories;

import com.gab.Server.entity.Curse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

import java.time.LocalDate;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

@Repository("curseRepository")
public class CurseRepository {
    
    @Autowired
    private MongoTemplate mongoTemplate;
    
    public List<Curse> findAll() {
        
        return mongoTemplate.findAll(Curse.class);
    }
    
    public List<Curse> findOrderByDateDesc() {
        
        return mongoTemplate.findAll(Curse.class).stream()
                .sorted(Comparator.comparing(Curse::getDate).reversed())
                .collect(Collectors.toList());
    }
    
    public Curse findLast() {
        
        return mongoTemplate.findAll(Curse.class).stream()
                .max(Comparator.comparing(Curse::getDate))
                .orElse(new Curse());
    }
    
    public void save(Curse curse) {
        
        mongoTemplate.save(curse);
    }
}
