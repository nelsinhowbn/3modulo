package controller;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;


import model.Vendedor;
 
public class VendedorJDAO {
 
         private static VendedorJDAO instance;
         protected EntityManager entityManager;
         
         public static VendedorJDAO getInstance(){
                   if (instance == null){
                            instance = new VendedorJDAO();
                   }
                   
                   return instance;
         }
 
         private VendedorJDAO() {
                   entityManager = getEntityManager();
         }
 
         private EntityManager getEntityManager() {
                   EntityManagerFactory factory = Persistence.createEntityManagerFactory("crudHibernatePU");
                   if (entityManager == null) {
                            entityManager = factory.createEntityManager();
                   }
 
                   return entityManager;
         }
 
         public Vendedor getById(final int id) {
                   return entityManager.find(Vendedor.class, id);
         }
 
         @SuppressWarnings("unchecked")
         public List<Vendedor> findAll() {
                   return entityManager.createQuery("FROM " + Vendedor.class.getName()).getResultList();
         }
         public void persist(Vendedor vendedor) {
             try {
                      entityManager.getTransaction().begin();
                      entityManager.persist(vendedor);
                      entityManager.getTransaction().commit();
             } catch (Exception ex) {
                      ex.printStackTrace();
                      entityManager.getTransaction().rollback();
             }
   }

 
         public void merge(Vendedor vendedor) {
                   try {
                            entityManager.getTransaction().begin();
                            entityManager.merge(vendedor);
                            entityManager.getTransaction().commit();
                   } catch (Exception ex) {
                            ex.printStackTrace();
                            entityManager.getTransaction().rollback();
                   }
         }
 
         public void remove(Vendedor vendedor) {
                   try {
                            entityManager.getTransaction().begin();
                            vendedor = entityManager.find(Vendedor.class, vendedor.getId());
                            entityManager.remove(vendedor);
                            entityManager.getTransaction().commit();
                   } catch (Exception ex) {
                            ex.printStackTrace();
                            entityManager.getTransaction().rollback();
                   }
         }
 
         public void removeById(final int id) {
                   try {
                            Vendedor vendedor = getById(id);
                            remove(vendedor);
                   } catch (Exception ex) {
                            ex.printStackTrace();
                   }
         }}