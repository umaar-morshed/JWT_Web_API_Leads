### .NET 6 Backend Authentication and Authorization System

This repository contains a .NET 6 backend application implementing authentication and authorization using JWT (JSON Web Tokens) and refresh tokens. The system provides the following features:

1. **Authorized Requests**: Every request to the backend is authenticated and authorized.

2. **User Registration Endpoint**: Allows users to register by providing a username and password. The backend generates a password salt and hash for secure storage.

3. **User Login Endpoint**: Users can log in by providing their username and password. The backend generates a JWT token with an expiration time specified in the `appsettings.json` file. Additionally, a refresh token is generated and set in the HTTP cookies.

4. **Secure Get Weather Data Endpoint**: A protected endpoint that requires a JWT token for access. The backend validates the JWT token to ensure it corresponds to the correct username and checks for token expiration.

5. **Get JWT Protected Claims Endpoint**: Provides an API endpoint to retrieve user claims (e.g., username information) using the `HttpContextAccessor`.

6. **Generate New Refresh Token Endpoint**: Allows users to generate a new refresh token after validating the existing refresh token by matching it with the refresh token stored in the user object.

### Next Steps
The following tasks are yet to be completed:

1. Develop a frontend application.
2. Integrate the frontend with the backend to enable user authentication and authorization.
3. Implement token storage in the server's memcache for improved performance and scalability.

Stay tuned for updates as we progress with the development and integration of the frontend!
