// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using System.Linq;

string API_KEY = "My_API_KEY";

// =====================================================
// GITGUARD TEST DATASET
// =====================================================

// ---------- AWS Access Key (CRITICAL) ----------
string awsKey = "AKIA1234567890ABCDEF";

// ---------- GitHub PAT (CRITICAL) ----------
string githubToken = "ghp_abcdefghijklmnopqrstuvwxyz1234567890";

// ---------- Google API Key (CRITICAL) ----------
string googleKey = "AIzaSyD123456789012345678901234567890123";

// ---------- Stripe Secret Key (CRITICAL) ----------
string stripeKey = "sk_live_123456789012345678901234567890";

// ---------- JWT Token (HIGH) ----------
string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.abcdefghijk123456789.xyz123456789abcdef";

// ---------- SendGrid API Key (CRITICAL) ----------
string sendGrid = "SG.1234567890123456789012.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNO123456";

// ---------- Connection String (HIGH) ----------
string conn = "postgres://admin:SuperSecret123@localhost:5432/mydb";

// ---------- Hardcoded Password (HIGH) ----------
string password = "MyStrongPassword123";

// ---------- Generic API Key Assignment (HIGH) ----------
string api_key = "ABCDEF1234567890ABCDEF1234567890";

// ---------- Private Key Header (CRITICAL) ----------
string privateKeyHeader = "-----BEGIN RSA PRIVATE KEY-----";

// =====================================================
// ENTROPY TESTS
// =====================================================

// Should trigger: High-Signal Entropy Assignment
string secret = "7fG93ksA92LmP8vQsK2n";

// Should trigger: High-Signal Entropy Assignment
string token = "Ab8xP92mLsQ8kT1vWzR3";

// Should ideally trigger: MEDIUM entropy
string key = "abcdef123456abcdef";

// Should ideally trigger: HIGH entropy
string credential = "mN8zQ2xL9vB7kJ1pR4sT6uW";

// Should trigger: High-Signal Entropy Assignment
string privateToken = "L8mQ2zX7cV9nB1kR4tY6";

// Same value without keyword context
string value = "L8mQ2zX7cV9nB1kR4tY6";

// Entropy stress test
string randomSecret = "aB9xK2mQ7rT5uV8wX1yZ3nP6";

// =====================================================
// PLACEHOLDER TESTS (SHOULD BE FILTERED)
// =====================================================

string placeholder1 = "your_api_key";
string placeholder2 = "insert_key_here";
string placeholder3 = "changeme";
string placeholder4 = "your_token";
string placeholder5 = "my_secret";
string placeholder6 = "example";

// =====================================================
// FALSE POSITIVE TESTS (SHOULD NOT TRIGGER)
// =====================================================

string city = "Nablus";
string country = "Palestine";
string username = "Khaled";
string project = "GitGuard";
string userId = "12345678901234567890";
string orderNumber = "98765432109876543210";
string version = "1.0.0";
string greeting = "HelloWorld";
string course = "CENG3544";

// =====================================================
// MIXED FILE TEST
// =====================================================

string github = "ghp_abcdefghijklmnopqrstuvwxyz1234567890";
string stripe = "sk_live_123456789012345678901234567890";
string adminPassword = "AdminPassword123";
string suspiciousSecret = "aB9xK2mQ7rT5uV8wX1yZ3nP6";

// =====================================================
// EDGE CASES
// =====================================================

// Should NOT trigger
string shortPassword = "123";

// Should NOT trigger
string samplePassword = "sample";

// Should NOT trigger
string examplePassword = "example";

// Should trigger password regex
string realPassword = "SuperAdminPassword2026";

// Should trigger API key regex
string apiKey = "ZXCVBNMASDFGHJKLQWERTY1234567890";

// Should trigger entropy
string secretValue = "xK8vM2nQ9rT4yP7sL1wZ";

// =====================================================
// END TEST DATASET
// =====================================================
