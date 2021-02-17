import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'nested_modals',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44343',
    redirectUri: baseUrl,
    clientId: 'nested_modals_App',
    responseType: 'code',
    scope: 'offline_access nested_modals',
  },
  apis: {
    default: {
      url: 'https://localhost:44343',
      rootNamespace: 'nested_modals',
    },
  },
} as Environment;
