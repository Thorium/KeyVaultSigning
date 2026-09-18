module Program =
    let [<EntryPoint>] main _ =
        let testContainer =
            KeyVaultSignTests.TestClass(
                keyvault = "isaac-hsm",
                certificateName = "loantest"
            )

        testContainer.``KeyVault sign test``()
        testContainer.``KeyVault sign and verify test``()
        0
