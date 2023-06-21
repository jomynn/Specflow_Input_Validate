Feature: InputValidation
    Scenario Outline: Validate String Type
        Given I have an input string "<Input>"
        When I validate the input as a "<Type>"
        Then the input should be "<ValidationResult>"

        Examples:
        | Input            | Type          | ValidationResult |
        | "12345"          | "number"      | "valid"          |
        | "test@example.com" | "email"     | "valid"          |
        | "123abc"         | "number"      | "invalid"        |
        | "invalid"        | "email"       | "invalid"        |
