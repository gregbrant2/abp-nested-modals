import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpModals',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44325',
    redirectUri: baseUrl,
    clientId: 'AbpModals_App',
    responseType: 'code',
    scope: 'offline_access AbpModals',
  },
  apis: {
    default: {
      url: 'https://localhost:44325',
      rootNamespace: 'AbpModals',
    },
  },
} as Environment;
