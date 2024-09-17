API_PROJECT_PATH = src/LXP.API/LXP.Api.csproj
SOLUTION_FILE = LXP.sln

# Build the solution
build:
	dotnet build $(SOLUTION_FILE)

# Run the API project
run: build
	dotnet run --project $(API_PROJECT_PATH)

# Clean the solution
clean:
	dotnet clean $(SOLUTION_FILE)

# Default target
.PHONY: default build run clean
default: build run clean
