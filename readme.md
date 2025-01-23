# **Tutorial Series: Securing DevOps Pipelines with DevSecOps**  

This tutorial is part of a **multi-part series** aimed at helping you **secure your DevOps pipelines** and implement an **effective DevSecOps process**.  

---

## **Scope of This Tutorial**  
This tutorial focuses on two primary areas:  

1. **Development Setup**  
   - Create a **simple .NET web application**.  
   - Fetch **secrets from Azure Key Vault**.  
   - Display the secrets on an **HTML page**.  

2. **CI/CD Pipeline in Azure DevOps**  
   - **Build & Push**: Containerize the application and push it to Azure Container Registry (ACR).  
   - **Security Scanning**:  
     - Perform **SAST with SonarQube**.  
     - Conduct **container scanning with Prisma Cloud**.  
   - **Automated Testing**: Run **unit, integration, and security tests**.  
   - **Secret Management**: Securely retrieve secrets from Azure Key Vault.  
   - **Deployment**: Deploy the application to **Azure Container Apps**.  

---

## **Prerequisites**  
Before following this tutorial, we assume the following infrastructure already exists:  

### **Azure Resources**  
- **Azure Container Registry (ACR)**  
- **Azure Container Apps**  
- **Azure Key Vault**  
- **Private Azure DevOps Agents**  

### **Security Tools**  
- **SonarQube server** for SAST.  
- **Prisma Cloud** for container security scanning.  

---

## **Configuration Steps**  
This tutorial will guide you through:  
- Setting up the **.NET web app**.  
- Configuring a **secure CI/CD pipeline**.  
- Integrating **security scans and secret management**.  
- Automating **deployment to Azure**.  
- Configuring an **Azure DevOps Variable Group (DEV)**.  

---

## **Steps to Follow**  
1. **Clone the Project**  
   - Clone the repository using Git.  

2. **Set Up Azure DevOps Pipelines**  
   - Create build and deploy pipelines based on the provided YAML configurations.  
3. **Configure the Azure DevOps Variable Group**  
   - Create a variable group named **DEV** with the following variables:  
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

4. **Create Azure DevOps Service Connection**  
   - Name the service connection **"DEV Service Connection"**.  
   - Ensure its SPN has the following roles:  
     - **AcrPull**: Allows pulling images from the Azure Container Registry.  
     - **Contributor**: Allows deploying and updating container apps.  
     - **List Permission**: Allows listing secrets in the Azure Key Vault.  

## **Useful Documentation Links**  

### **Azure DevOps**  
- [Azure DevOps Pipelines Documentation](https://learn.microsoft.com/en-us/azure/devops/pipelines/)  
- [Azure DevOps Service Connections](https://learn.microsoft.com/en-us/azure/devops/pipelines/library/service-endpoints)  
- [Azure DevOps Variable Groups](https://learn.microsoft.com/en-us/azure/devops/pipelines/library/variable-groups)  

### **Azure Services**  
- [Azure Container Registry](https://learn.microsoft.com/en-us/azure/container-registry/)  
- [Azure Container Apps](https://learn.microsoft.com/en-us/azure/container-apps/)  
- [Azure Key Vault](https://learn.microsoft.com/en-us/azure/key-vault/)  

### **Security Tools**  
- [SonarQube Documentation](https://docs.sonarsource.com/)  
- [Prisma Cloud Documentation](https://docs.paloaltonetworks.com/prisma/prisma-cloud)  
