FROM node:20-alpine AS restore
WORKDIR /app
COPY package*.json ./
RUN npm install

FROM restore AS build
# RUN npm cache clean --force
COPY . .
RUN npm run build --prod

FROM nginx:latest AS runtime
# RUN rm /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist/courseplatform.client/browser/ /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]

