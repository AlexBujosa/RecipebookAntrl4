//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\kirot\source\repos\AnlrArbol\AnlrArbol\recipebook.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class recipebookLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LINE_START=1, GUION=2, REC_LBL=3, POR_LBL=4, TMP_LBL=5, TMC_LBL=6, CAL_LBL=7, 
		ING_LBL=8, ELA_LBL=9, LIST_ORDER_SEP=10, COM=11, SEP=12, TAB=13, WS=14, 
		NL=15, NUMBER=16, FLOAT=17, INTEGER=18, CARRRET=19, MEASURE_UNIT=20, TIME_UNIT=21, 
		TEXT=22, WORD=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LINE_START", "GUION", "REC_LBL", "POR_LBL", "TMP_LBL", "TMC_LBL", "CAL_LBL", 
		"ING_LBL", "ELA_LBL", "LIST_ORDER_SEP", "COM", "SEP", "TAB", "WS", "NL", 
		"NUMBER", "FLOAT", "INTEGER", "CARRRET", "MEASURE_UNIT", "TIME_UNIT", 
		"TEXT", "WORD"
	};


	public recipebookLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public recipebookLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'-'", "'RECETA'", "'PORCIONES'", "'TIEMPO PREPARACION'", 
		"'TIEMPO COCCION'", "'CALORIAS'", "'INGREDIENTES'", "'ELABORACION'", "')'", 
		"','", "':'", "'\t'", null, "'\n'", null, null, null, "'\r'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LINE_START", "GUION", "REC_LBL", "POR_LBL", "TMP_LBL", "TMC_LBL", 
		"CAL_LBL", "ING_LBL", "ELA_LBL", "LIST_ORDER_SEP", "COM", "SEP", "TAB", 
		"WS", "NL", "NUMBER", "FLOAT", "INTEGER", "CARRRET", "MEASURE_UNIT", "TIME_UNIT", 
		"TEXT", "WORD"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "recipebook.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static recipebookLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\xF4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x6', '\xF', 
		'\x95', '\n', '\xF', '\r', '\xF', '\xE', '\xF', '\x96', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x5', '\x11', '\x9D', '\n', 
		'\x11', '\x3', '\x12', '\x6', '\x12', '\xA0', '\n', '\x12', '\r', '\x12', 
		'\xE', '\x12', '\xA1', '\x3', '\x12', '\x3', '\x12', '\x6', '\x12', '\xA6', 
		'\n', '\x12', '\r', '\x12', '\xE', '\x12', '\xA7', '\x3', '\x13', '\x6', 
		'\x13', '\xAB', '\n', '\x13', '\r', '\x13', '\xE', '\x13', '\xAC', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x5', '\x15', '\xC2', 
		'\n', '\x15', '\x3', '\x15', '\x5', '\x15', '\xC5', '\n', '\x15', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x5', '\x16', '\xE2', '\n', '\x16', '\x3', '\x16', 
		'\x5', '\x16', '\xE5', '\n', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\a', '\x17', '\xEB', '\n', '\x17', '\f', '\x17', 
		'\xE', '\x17', '\xEE', '\v', '\x17', '\x3', '\x18', '\x6', '\x18', '\xF1', 
		'\n', '\x18', '\r', '\x18', '\xE', '\x18', '\xF2', '\x2', '\x2', '\x19', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', 
		'\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', 
		'#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', 
		'\x18', '/', '\x19', '\x3', '\x2', '\x4', '\x3', '\x2', '\x32', ';', '\x5', 
		'\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x2', '\x103', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x31', '\x3', '\x2', '\x2', '\x2', '\x5', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x36', '\x3', '\x2', '\x2', '\x2', '\t', '=', '\x3', 
		'\x2', '\x2', '\x2', '\v', 'G', '\x3', '\x2', '\x2', '\x2', '\r', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '\xF', 'i', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'r', '\x3', '\x2', '\x2', '\x2', '\x13', '\x7F', '\x3', '\x2', '\x2', 
		'\x2', '\x15', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x17', '\x8D', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x91', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x94', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '\x98', '\x3', '\x2', '\x2', '\x2', '!', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '#', '\x9F', '\x3', '\x2', '\x2', '\x2', '%', '\xAA', 
		'\x3', '\x2', '\x2', '\x2', '\'', '\xAE', '\x3', '\x2', '\x2', '\x2', 
		')', '\xC1', '\x3', '\x2', '\x2', '\x2', '+', '\xE1', '\x3', '\x2', '\x2', 
		'\x2', '-', '\xE6', '\x3', '\x2', '\x2', '\x2', '/', '\xF0', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x32', '\x5', '\x5', '\x3', '\x2', '\x32', '\x33', 
		'\x5', '\x1D', '\xF', '\x2', '\x33', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x35', '\a', '/', '\x2', '\x2', '\x35', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '\x37', '\a', 'T', '\x2', '\x2', '\x37', '\x38', 
		'\a', 'G', '\x2', '\x2', '\x38', '\x39', '\a', '\x45', '\x2', '\x2', '\x39', 
		':', '\a', 'G', '\x2', '\x2', ':', ';', '\a', 'V', '\x2', '\x2', ';', 
		'<', '\a', '\x43', '\x2', '\x2', '<', '\b', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\a', 'R', '\x2', '\x2', '>', '?', '\a', 'Q', '\x2', '\x2', 
		'?', '@', '\a', 'T', '\x2', '\x2', '@', '\x41', '\a', '\x45', '\x2', '\x2', 
		'\x41', '\x42', '\a', 'K', '\x2', '\x2', '\x42', '\x43', '\a', 'Q', '\x2', 
		'\x2', '\x43', '\x44', '\a', 'P', '\x2', '\x2', '\x44', '\x45', '\a', 
		'G', '\x2', '\x2', '\x45', '\x46', '\a', 'U', '\x2', '\x2', '\x46', '\n', 
		'\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', 'V', '\x2', '\x2', 'H', 'I', 
		'\a', 'K', '\x2', '\x2', 'I', 'J', '\a', 'G', '\x2', '\x2', 'J', 'K', 
		'\a', 'O', '\x2', '\x2', 'K', 'L', '\a', 'R', '\x2', '\x2', 'L', 'M', 
		'\a', 'Q', '\x2', '\x2', 'M', 'N', '\a', '\"', '\x2', '\x2', 'N', 'O', 
		'\a', 'R', '\x2', '\x2', 'O', 'P', '\a', 'T', '\x2', '\x2', 'P', 'Q', 
		'\a', 'G', '\x2', '\x2', 'Q', 'R', '\a', 'R', '\x2', '\x2', 'R', 'S', 
		'\a', '\x43', '\x2', '\x2', 'S', 'T', '\a', 'T', '\x2', '\x2', 'T', 'U', 
		'\a', '\x43', '\x2', '\x2', 'U', 'V', '\a', '\x45', '\x2', '\x2', 'V', 
		'W', '\a', 'K', '\x2', '\x2', 'W', 'X', '\a', 'Q', '\x2', '\x2', 'X', 
		'Y', '\a', 'P', '\x2', '\x2', 'Y', '\f', '\x3', '\x2', '\x2', '\x2', 'Z', 
		'[', '\a', 'V', '\x2', '\x2', '[', '\\', '\a', 'K', '\x2', '\x2', '\\', 
		']', '\a', 'G', '\x2', '\x2', ']', '^', '\a', 'O', '\x2', '\x2', '^', 
		'_', '\a', 'R', '\x2', '\x2', '_', '`', '\a', 'Q', '\x2', '\x2', '`', 
		'\x61', '\a', '\"', '\x2', '\x2', '\x61', '\x62', '\a', '\x45', '\x2', 
		'\x2', '\x62', '\x63', '\a', 'Q', '\x2', '\x2', '\x63', '\x64', '\a', 
		'\x45', '\x2', '\x2', '\x64', '\x65', '\a', '\x45', '\x2', '\x2', '\x65', 
		'\x66', '\a', 'K', '\x2', '\x2', '\x66', 'g', '\a', 'Q', '\x2', '\x2', 
		'g', 'h', '\a', 'P', '\x2', '\x2', 'h', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'i', 'j', '\a', '\x45', '\x2', '\x2', 'j', 'k', '\a', '\x43', '\x2', '\x2', 
		'k', 'l', '\a', 'N', '\x2', '\x2', 'l', 'm', '\a', 'Q', '\x2', '\x2', 
		'm', 'n', '\a', 'T', '\x2', '\x2', 'n', 'o', '\a', 'K', '\x2', '\x2', 
		'o', 'p', '\a', '\x43', '\x2', '\x2', 'p', 'q', '\a', 'U', '\x2', '\x2', 
		'q', '\x10', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', 'K', '\x2', '\x2', 
		's', 't', '\a', 'P', '\x2', '\x2', 't', 'u', '\a', 'I', '\x2', '\x2', 
		'u', 'v', '\a', 'T', '\x2', '\x2', 'v', 'w', '\a', 'G', '\x2', '\x2', 
		'w', 'x', '\a', '\x46', '\x2', '\x2', 'x', 'y', '\a', 'K', '\x2', '\x2', 
		'y', 'z', '\a', 'G', '\x2', '\x2', 'z', '{', '\a', 'P', '\x2', '\x2', 
		'{', '|', '\a', 'V', '\x2', '\x2', '|', '}', '\a', 'G', '\x2', '\x2', 
		'}', '~', '\a', 'U', '\x2', '\x2', '~', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x7F', '\x80', '\a', 'G', '\x2', '\x2', '\x80', '\x81', '\a', 'N', '\x2', 
		'\x2', '\x81', '\x82', '\a', '\x43', '\x2', '\x2', '\x82', '\x83', '\a', 
		'\x44', '\x2', '\x2', '\x83', '\x84', '\a', 'Q', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'T', '\x2', '\x2', '\x85', '\x86', '\a', '\x43', '\x2', 
		'\x2', '\x86', '\x87', '\a', '\x45', '\x2', '\x2', '\x87', '\x88', '\a', 
		'K', '\x2', '\x2', '\x88', '\x89', '\a', 'Q', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 'P', '\x2', '\x2', '\x8A', '\x14', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', '+', '\x2', '\x2', '\x8C', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x8D', '\x8E', '\a', '.', '\x2', '\x2', '\x8E', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\x8F', '\x90', '\a', '<', '\x2', '\x2', '\x90', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', '\a', '\v', '\x2', 
		'\x2', '\x92', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x93', '\x95', '\a', 
		'\"', '\x2', '\x2', '\x94', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', 
		'\x96', '\x3', '\x2', '\x2', '\x2', '\x96', '\x94', '\x3', '\x2', '\x2', 
		'\x2', '\x96', '\x97', '\x3', '\x2', '\x2', '\x2', '\x97', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x99', '\a', '\f', '\x2', '\x2', '\x99', 
		' ', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9D', '\x5', '%', '\x13', '\x2', 
		'\x9B', '\x9D', '\x5', '#', '\x12', '\x2', '\x9C', '\x9A', '\x3', '\x2', 
		'\x2', '\x2', '\x9C', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9D', '\"', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\xA0', '\t', '\x2', '\x2', '\x2', 
		'\x9F', '\x9E', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '\xA1', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA1', '\xA2', 
		'\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', 
		'\xA3', '\xA5', '\a', '\x30', '\x2', '\x2', '\xA4', '\xA6', '\t', '\x2', 
		'\x2', '\x2', '\xA5', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', 
		'\x3', '\x2', '\x2', '\x2', '\xA7', '\xA5', '\x3', '\x2', '\x2', '\x2', 
		'\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', '$', '\x3', '\x2', 
		'\x2', '\x2', '\xA9', '\xAB', '\t', '\x2', '\x2', '\x2', '\xAA', '\xA9', 
		'\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\x3', '\x2', '\x2', '\x2', 
		'\xAC', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAD', '\x3', '\x2', 
		'\x2', '\x2', '\xAD', '&', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', 
		'\a', '\xF', '\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB1', '\b', '\x14', '\x2', '\x2', '\xB1', '(', '\x3', '\x2', 
		'\x2', '\x2', '\xB2', '\xB3', '\a', 'v', '\x2', '\x2', '\xB3', '\xB4', 
		'\a', '\x63', '\x2', '\x2', '\xB4', '\xB5', '\a', '|', '\x2', '\x2', '\xB5', 
		'\xC2', '\a', '\x63', '\x2', '\x2', '\xB6', '\xB7', '\a', '\x65', '\x2', 
		'\x2', '\xB7', '\xB8', '\a', 'w', '\x2', '\x2', '\xB8', '\xB9', '\a', 
		'\x65', '\x2', '\x2', '\xB9', '\xBA', '\a', 'j', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', '\x63', '\x2', '\x2', '\xBB', '\xBC', '\a', 't', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', '\x63', '\x2', '\x2', '\xBD', '\xBE', '\a', 
		'\x66', '\x2', '\x2', '\xBE', '\xBF', '\a', 'k', '\x2', '\x2', '\xBF', 
		'\xC0', '\a', 'v', '\x2', '\x2', '\xC0', '\xC2', '\a', '\x63', '\x2', 
		'\x2', '\xC1', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xB6', '\x3', 
		'\x2', '\x2', '\x2', '\xC2', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC3', 
		'\xC5', '\a', 'u', '\x2', '\x2', '\xC4', '\xC3', '\x3', '\x2', '\x2', 
		'\x2', '\xC4', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC5', '*', '\x3', 
		'\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', 'o', '\x2', '\x2', '\xC7', 
		'\xC8', '\a', 'k', '\x2', '\x2', '\xC8', '\xE2', '\a', 'p', '\x2', '\x2', 
		'\xC9', '\xCA', '\a', 'o', '\x2', '\x2', '\xCA', '\xCB', '\a', 'k', '\x2', 
		'\x2', '\xCB', '\xCC', '\a', 'p', '\x2', '\x2', '\xCC', '\xCD', '\a', 
		'w', '\x2', '\x2', '\xCD', '\xCE', '\a', 'v', '\x2', '\x2', '\xCE', '\xE2', 
		'\a', 'g', '\x2', '\x2', '\xCF', '\xD0', '\a', 'u', '\x2', '\x2', '\xD0', 
		'\xD1', '\a', 'g', '\x2', '\x2', '\xD1', '\xE2', '\a', '\x65', '\x2', 
		'\x2', '\xD2', '\xD3', '\a', 'u', '\x2', '\x2', '\xD3', '\xD4', '\a', 
		'g', '\x2', '\x2', '\xD4', '\xD5', '\a', '\x65', '\x2', '\x2', '\xD5', 
		'\xD6', '\a', 'q', '\x2', '\x2', '\xD6', '\xD7', '\a', 'p', '\x2', '\x2', 
		'\xD7', '\xE2', '\a', '\x66', '\x2', '\x2', '\xD8', '\xD9', '\a', 'j', 
		'\x2', '\x2', '\xD9', '\xE2', '\a', 't', '\x2', '\x2', '\xDA', '\xDB', 
		'\a', 'j', '\x2', '\x2', '\xDB', '\xDC', '\a', 'q', '\x2', '\x2', '\xDC', 
		'\xDD', '\a', 'w', '\x2', '\x2', '\xDD', '\xE2', '\a', 't', '\x2', '\x2', 
		'\xDE', '\xDF', '\a', '\x66', '\x2', '\x2', '\xDF', '\xE0', '\a', '\x63', 
		'\x2', '\x2', '\xE0', '\xE2', '\a', '{', '\x2', '\x2', '\xE1', '\xC6', 
		'\x3', '\x2', '\x2', '\x2', '\xE1', '\xC9', '\x3', '\x2', '\x2', '\x2', 
		'\xE1', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xD2', '\x3', '\x2', 
		'\x2', '\x2', '\xE1', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xDA', 
		'\x3', '\x2', '\x2', '\x2', '\xE1', '\xDE', '\x3', '\x2', '\x2', '\x2', 
		'\xE2', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE5', '\a', 'u', 
		'\x2', '\x2', '\xE4', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', '\xE5', ',', '\x3', '\x2', '\x2', '\x2', '\xE6', 
		'\xEC', '\x5', '/', '\x18', '\x2', '\xE7', '\xE8', '\x5', '\x1D', '\xF', 
		'\x2', '\xE8', '\xE9', '\x5', '/', '\x18', '\x2', '\xE9', '\xEB', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xEE', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xEA', '\x3', '\x2', '\x2', 
		'\x2', '\xEC', '\xED', '\x3', '\x2', '\x2', '\x2', '\xED', '.', '\x3', 
		'\x2', '\x2', '\x2', '\xEE', '\xEC', '\x3', '\x2', '\x2', '\x2', '\xEF', 
		'\xF1', '\t', '\x3', '\x2', '\x2', '\xF0', '\xEF', '\x3', '\x2', '\x2', 
		'\x2', '\xF1', '\xF2', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF0', '\x3', 
		'\x2', '\x2', '\x2', '\xF2', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF3', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xE', '\x2', '\x96', '\x9C', '\xA1', 
		'\xA7', '\xAC', '\xC1', '\xC4', '\xE1', '\xE4', '\xEC', '\xF2', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
