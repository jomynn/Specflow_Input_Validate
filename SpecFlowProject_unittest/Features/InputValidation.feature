Feature: InputValidation
    Scenario Outline: Validate String Type
        Given I have an input string <input>
        When I validate the <input> and <type>
        Then the <input> and <type> should be <validationResult>

        Examples:
        | input            | type          | validationResult |
        | "12345"          | "number"      | "valid"          |
        | "test@example.com" | "email"     | "valid"          |
        | "123abc"         | "number"      | "invalid"        |
        | "invalid"        | "email"       | "invalid"        |
