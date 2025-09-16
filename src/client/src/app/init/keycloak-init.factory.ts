import { KeycloakService } from "keycloak-angular";

export function initializeKeycloak(
  keycloak: KeycloakService
  ) {
    return () =>
      keycloak.init({
        config: {
          url: 'http://localhost:8080',
          realm: 'course-platform',
          clientId: 'public-client',
        },
        initOptions: {
          checkLoginIframe: false,
          redirectUri: 'http://localhost:4200/courses'
        }
      });
}