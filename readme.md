# **Tutorial Series: Securing DevOps Pipelines with DevSecOps**  

This tutorial is part of a **multi-part series** aimed at helping you **secure your DevOps pipelines** and implement a **better DevSecOps process**.  

## **Scope of This Tutorial**  
In this tutorial, we will focus on:  
1. **Development Setup**:  
   - Create a **simple .NET web app**.  
   - Fetch **secrets from Azure Key Vault**.  
   - Display secrets on an **HTML page**.  

2. **CI/CD Pipeline in Azure DevOps**:  
   - **Build & Push**: Containerize and push to ACR.  
   - **Security Scanning**:  
     - **SAST** with SonarQube.  
     - **Container Scanning** with Prisma Cloud.  
   - **Automated Testing**: Unit, integration, and security tests.  
   - **Secret Management**: Retrieve secrets securely from Key Vault.  
   - **Deployment**: Deploy to Azure **Container Apps**.  

## **Prerequisites**  
We assume the following infrastructure already exists:  
- **Azure Resources**:  
  - **Azure Container Registry (ACR)**  
  - **Azure Container Apps**  
  - **Azure Key Vault**  
  - **Private Azure DevOps Agents**  

- **Security Tools**:  
  - **SonarQube server** for SAST.  
  - **Prisma Cloud** for container scanning.  

## **Next Steps**  
This tutorial will guide you through:  
- Setting up the .NET web app.  
- Configuring a **secure CI/CD pipeline**.  
- Integrating security scans and secret management.  
- Automating deployment to Azure.  

🚀 Stay tuned for future tutorials covering additional security scopes!  
