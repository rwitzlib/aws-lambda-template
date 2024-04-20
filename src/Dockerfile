FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine as publish
WORKDIR /app

COPY . .

RUN dotnet restore -r linux-x64 /p:PublishReadyToRun=true
RUN dotnet publish -c Release -o ./publish -r linux-x64 --self-contained true --no-restore /p:PublishTrimmed=true /p:PublishReadyToRun=true

FROM public.ecr.aws/lambda/dotnet:8 AS final
WORKDIR /app

EXPOSE 8080
EXPOSE 443

COPY --from=publish /app/publish/* ${LAMBDA_TASK_ROOT}
  
CMD [ "Template::Template.Function::FunctionHandler" ]