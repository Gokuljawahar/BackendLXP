{ pkgs, ... }: {
  # Which nixpkgs channel to use.
  channel = "stable-23.11"; # or "unstable"

  # Use https://search.nixos.org/packages to find packages
  packages = [
    pkgs.dotnet-sdk_8
    pkgs.dotnet-runtime_8
    pkgs.dotnet-aspnetcore_8
    pkgs.csharpier
  ];

  # Sets environment variables in the workspace
  env = {
    # Add any environment variables you need here
  };

  idx = {
    # Search for the extensions you want on https://open-vsx.org/ and use "publisher.id"
    extensions = [
      "ms-dotnettools.vscode-dotnet-runtime"
      "muhammad-sammy.csharp"
      "eamodio.gitlens"
      "k--kato.docomment"
    ];

    # Enable previews
    previews = {
      enable = true;
      previews = {
        # web = {
        #   # Example: run "npm run dev" with PORT set to IDX's defined port for previews,
        #   # and show it in IDX's web preview panel
        #   command = ["npm" "run" "dev"];
        #   manager = "web";
        #   env = {
        #     # Environment variables to set for your server
        #     PORT = "$PORT";
        #   };
        # };
      };
    };

    # Workspace lifecycle hooks
    workspace = {
      # Runs when a workspace is first created
      onCreate = {
        # Example: restore .NET dependencies
        dotnet-restore = "dotnet restore /home/user/BackendLXP/LXP.API/LXP.Api.csproj";
      };
      # Runs when the workspace is (re)started
      onStart = {
        # Example: start a background task to watch and re-build backend code
        watch-backend = "dotnet watch --project /home/user/BackendLXP/LXP.API/LXP.Api.csproj run";
      };
    };
  };
  }
