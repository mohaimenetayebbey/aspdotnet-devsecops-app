This tutorial is part of a **multi-part series** designed to help you **secure your DevOps pipelines** and implement an **effective DevSecOps process**.  

### **Scope of This Tutorial**  
In this part, we will focus on two key areas:  

1. **Development Setup**  
   - Create a **simple .NET web application**.  
   - Fetch **secrets from Azure Key Vault**.  
   - Display the secrets on an **HTML page**.  

2. **CI/CD Pipeline in Azure DevOps**  
   - **Build & Push**: Containerize the application and push it to Azure Container Registry (ACR).  
   - **Security Scanning**: Perform **SAST with SonarQube** and **container scanning with Prisma Cloud**.  
   - **Automated Testing**: Run **unit, integration, and security tests**.  
   - **Secret Management**: Securely retrieve secrets from Azure Key Vault.  
   - **Deployment**: Deploy the application to **Azure Container Apps**.  

### **Prerequisites**  
Before following this tutorial, we assume the following infrastructure already exists:  

- **Azure Resources**  
  - **Azure Container Registry (ACR)**  
  - **Azure Container Apps**  
  - **Azure Key Vault**  
  - **Private Azure DevOps Agents**  

- **Security Tools**  
  - **SonarQube server** for SAST.  
  - **Prisma Cloud** for container security scanning.  

### **Configuration Steps**  
This tutorial will guide you through:  
- Setting up the **.NET web app**.  
- Configuring a **secure CI/CD pipeline**.  
- Integrating **security scans and secret management**.  
- Automating **deployment to Azure**.  
- Configuring an **Azure DevOps Variable Group (DEV)**:  

Everything is already configured, all you have to do is to follow these steps  

Steps:  
- Clone the project using Git.  
- Create the Azure DevOps pipelines based on the build and deploy YAML codes.  
- Create the **DEV** variable group using the following variables:  
  - `ACR_NAME` → Azure Container Registry name.  
  - `RESOURCE_GROUP` → Azure Resource Group name.  
  - `IMAGE_NAME` → Name of the container image.  
  - `TAG` → Image tag (e.g., latest, v1.0.0).  
  - `CONTAINER_APP_NAME` → Azure Container App name.  
  - `SONAR_PROJECT_KEY` → SonarQube project key.  
  - `SONAR_HOST_URL` → SonarQube server URL.  
  - `SONAR_TOKEN` → SonarQube authentication token.  
  - `PRISMA_URL` → Prisma Cloud API URL.  
  - `PRISMA_USERNAME` → Prisma Cloud username.  
  - `PRISMA_PASSWORD` → Prisma Cloud password.  
- Create a service connection in Azure DevOps named DEV Service Connection and ensure it's SPN has the necessary access rights:
  - **AcrPull**:  
    - Allows pulling images from the Azure Container Registry.
    - **Contributor**:  
      - Allows deploying and updating container apps.
    - **List Permission**:  
      - Allows listing secrets in the Azure Key Vault.
