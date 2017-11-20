FROM microsoft/aspnetcore-build:2.0
COPY . /infrastructure
WORKDIR /infrastructure
RUN ["dotnet", "restore"]
RUN chmod +x ./initialize.sh
CMD /bin/bash ./initialize.sh