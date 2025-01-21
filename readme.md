# **Tutorial: Secure .NET App Deployment with DevSecOps**

## **Step 1: Setup Development**
- Create **.NET 7.0 app**.
- Write **Dockerfile** (multi-stage build).

## **Step 2: Provision Azure Infrastructure**
- Deploy **ACR, AKS/Container Apps, Key Vault, DevOps Agents** using Terraform.
- Apply **RBAC, encryption, network isolation**.

## **Step 3: CI/CD Pipeline (Azure DevOps)**
- **Build & Push**: Build Docker image, push to ACR.
- **Security Scanning**:  
  - **SAST** (CodeQL, SonarQube).  
  - **Prisma Cloud (TwistCLI)**:  
    - **Static Scan** (image vulnerabilities).  
    - **Dynamic Scan** (runtime threats).  
- **Automated Testing**: Run **unit, integration, security tests**.
- **Secret Management**: Fetch secrets from **Azure Key Vault**.
- **Deploy**: Deploy to **AKS/Container Apps** (immutable).
- **Security Gates**: Enforce **Terraform validation, policy checks, block vulnerabilities**.

## **Step 4: Monitor & Maintain**
- Enable **Prisma Cloud runtime security**.
- Automate **patching, updates, compliance checks**.

Would you like detailed scripts or configs for any step? 🚀
