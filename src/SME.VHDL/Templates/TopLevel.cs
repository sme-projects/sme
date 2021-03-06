﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SME.VHDL.Templates {
    using System.Linq;
    using SME;
    using SME.VHDL;
    using System.Text;
    using System.Collections.Generic;
    using SME.AST;
    using System;
    
    
    public partial class TopLevel : TopLevelBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 9 ""
            this.Write("library IEEE;\nuse IEEE.STD_LOGIC_1164.ALL;\nuse IEEE.NUMERIC_STD.ALL;\n\n-- library SYSTEM_TYPES;\nuse work.SYSTEM_TYPES.ALL;\n\n-- library CUSTOM_TYPES;\nuse work.CUSTOM_TYPES.ALL;\n\n-- User defined packages here\n-- #### USER-DATA-IMPORTS-START\n-- #### USER-DATA-IMPORTS-END\n\nentity ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Network.Name ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(" is\n  port(\n\n");
            
            #line default
            #line hidden
            
            #line 26 ""

var feedbacks = RS.FeedbackBusses.ToArray();

            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 30 ""
 foreach (var bus in Network.Busses.Where(x => !x.IsInternal)) { 
	var signaltype = "inout"; 

	if (bus.IsTopLevelInput && !bus.IsTopLevelOutput)
		signaltype = "in";
	else if (bus.IsTopLevelOutput && !bus.IsTopLevelInput)
		signaltype = "out";

            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write("    -- Top-level bus ");
            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write(" signals\n");
            
            #line default
            #line hidden
            
            #line 39 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(": ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signaltype ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 41 ""
     } 
            
            #line default
            #line hidden
            
            #line 42 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 43 ""
 } 
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("\n    -- User defined signals here\n    -- #### USER-DATA-ENTITYSIGNALS-START\n    -- #### USER-DATA-ENTITYSIGNALS-END\n\n\t-- Reset signal\n    RST : in Std_logic;\n\n\t-- Clock signal\n\tCLK : in Std_logic\n  );\nend ");
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Network.Name ));
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(";\n\narchitecture RTL of ");
            
            #line default
            #line hidden
            
            #line 57 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Network.Name ));
            
            #line default
            #line hidden
            
            #line 57 ""
            this.Write(" is  \n  -- User defined signals here\n  -- #### USER-DATA-SIGNALS-START\n  -- #### USER-DATA-SIGNALS-END\n\n  -- Internal wiring signals for clocked processes\n");
            
            #line default
            #line hidden
            
            #line 63 ""
 foreach (var bus in Network.Busses.Where(x => !x.IsInternal && x.IsClocked && !feedbacks.Contains(x))) { 
            
            #line default
            #line hidden
            
            #line 64 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write("    signal ");
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write("_next: ");
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 66 ""
     } 
            
            #line default
            #line hidden
            
            #line 67 ""
 } 
            
            #line default
            #line hidden
            
            #line 68 ""
 if (feedbacks.Length > 0) { 
            
            #line default
            #line hidden
            
            #line 69 ""
            this.Write("\n    -- Feedback signals\n");
            
            #line default
            #line hidden
            
            #line 71 ""
     foreach (var bus in feedbacks) { 
            
            #line default
            #line hidden
            
            #line 72 ""
         foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("    signal ");
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("_current, ");
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write("_next: ");
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 73 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 74 ""
         } 
            
            #line default
            #line hidden
            
            #line 75 ""
     } 
            
            #line default
            #line hidden
            
            #line 76 ""
 } 
            
            #line default
            #line hidden
            
            #line 77 ""
            this.Write("\nbegin\n\n");
            
            #line default
            #line hidden
            
            #line 80 ""
 foreach (var p in Network.Processes.Where(x => !x.IsSimulation)) { 
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write("\n    -- Entity  ");
            
            #line default
            #line hidden
            
            #line 82 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Name ));
            
            #line default
            #line hidden
            
            #line 82 ""
            this.Write(" signals\n    ");
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Name ));
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(": entity work.");
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Name ));
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write("\n    port map (\n");
            
            #line default
            #line hidden
            
            #line 85 ""
    foreach (var bus in p.InputBusses.Union(p.OutputBusses).Distinct()) { 
	      var isInput = p.InputBusses.Contains(bus);
	      var isOutput = p.OutputBusses.Contains(bus);
	      var isBoth = isInput && isOutput;
	      var type = "Input/Output";
	      if (isInput && !isOutput)
	          type = "Input";
	      else if (isOutput && !isInput)
	          type = "Output";

	      var output_suffix = string.Empty;
	      var input_suffix = string.Empty;
	      if (bus.IsClocked || feedbacks.Contains(bus))
	          output_suffix = "_next";
	      if (feedbacks.Contains(bus))
	          input_suffix = "_current";

          var signals = bus.Signals.AsEnumerable();

	      if (isOutput && !isBoth)
	      	signals = RS.WrittenSignals(p, bus);

            
            #line default
            #line hidden
            
            #line 107 ""
            this.Write("        -- ");
            
            #line default
            #line hidden
            
            #line 107 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( type ));
            
            #line default
            #line hidden
            
            #line 107 ""
            this.Write(" bus ");
            
            #line default
            #line hidden
            
            #line 107 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 107 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 108 ""
		  foreach(var signal in signals) { 
            
            #line default
            #line hidden
            
            #line 109 ""
              if (isInput || isBoth) { 
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(" => ");
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( input_suffix ));
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write(",\n");
            
            #line default
            #line hidden
            
            #line 111 ""
              } else { 
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(" => ");
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( output_suffix ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(",\n");
            
            #line default
            #line hidden
            
            #line 113 ""
              } 
            
            #line default
            #line hidden
            
            #line 114 ""
        } 
            
            #line default
            #line hidden
            
            #line 115 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 116 ""
        if (isBoth) { 
            
            #line default
            #line hidden
            
            #line 117 ""
		      foreach(var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write("        out_");
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(" => ");
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( output_suffix ));
            
            #line default
            #line hidden
            
            #line 118 ""
            this.Write(",\n");
            
            #line default
            #line hidden
            
            #line 119 ""
            } 
            
            #line default
            #line hidden
            
            #line 120 ""
        } 
            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 122 ""
    } 
            
            #line default
            #line hidden
            
            #line 123 ""
            this.Write("        RST => RST,\n        CLK => CLK\n    );\n\n");
            
            #line default
            #line hidden
            
            #line 127 ""
 } 
            
            #line default
            #line hidden
            
            #line 128 ""
            this.Write("\n    -- Propagate all feedback signals immediately\n");
            
            #line default
            #line hidden
            
            #line 130 ""
 foreach(var bus in feedbacks) { 
            
            #line default
            #line hidden
            
            #line 131 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(" <= ");
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.IsClocked ? "_current" : "_next" ));
            
            #line default
            #line hidden
            
            #line 132 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 133 ""
     } 
            
            #line default
            #line hidden
            
            #line 134 ""
 } 
            
            #line default
            #line hidden
            
            #line 135 ""
            this.Write("\n    -- Propagate all clocked and feedback signals\n    process(\n        CLK,\n        RST)\n    begin\n        if RST = '1' then\n");
            
            #line default
            #line hidden
            
            #line 142 ""
 foreach(var bus in Network.Busses.Where(x => !x.IsInternal && x.IsClocked && !feedbacks.Contains(x))) { 
            
            #line default
            #line hidden
            
            #line 143 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(" <= ");
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.DefaultValue(signal) ));
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 145 ""
     } 
            
            #line default
            #line hidden
            
            #line 146 ""
 } 
            
            #line default
            #line hidden
            
            #line 147 ""
 foreach(var bus in feedbacks) { 
            
            #line default
            #line hidden
            
            #line 148 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write("_current <= ");
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.DefaultValue(signal) ));
            
            #line default
            #line hidden
            
            #line 149 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 150 ""
     } 
            
            #line default
            #line hidden
            
            #line 151 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 152 ""
 } 
            
            #line default
            #line hidden
            
            #line 153 ""
            this.Write("        elsif rising_edge(CLK) then\n");
            
            #line default
            #line hidden
            
            #line 154 ""
 foreach(var bus in Network.Busses.Where(x => !x.IsInternal && x.IsClocked && !feedbacks.Contains(x))) { 
            
            #line default
            #line hidden
            
            #line 155 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(" <= ");
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("_next;\n");
            
            #line default
            #line hidden
            
            #line 157 ""
     } 
            
            #line default
            #line hidden
            
            #line 158 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 159 ""
 } 
            
            #line default
            #line hidden
            
            #line 160 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 161 ""
 foreach(var bus in feedbacks) { 
            
            #line default
            #line hidden
            
            #line 162 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write("_current <= ");
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write("_");
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 163 ""
            this.Write("_next;\n");
            
            #line default
            #line hidden
            
            #line 164 ""
     } 
            
            #line default
            #line hidden
            
            #line 165 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 166 ""
 } 
            
            #line default
            #line hidden
            
            #line 167 ""
            this.Write("\n        end if;\n    end process;\n\n-- User defined processes here\n-- #### USER-DATA-CODE-START\n-- #### USER-DATA-CODE-END\n\nend RTL;");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class TopLevelBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
