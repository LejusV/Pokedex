using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zeraora Species to store common natural stats of all Zeraoras
	#region SpeciesZeraora
	public class SpeciesZeraora : PokemonSpecies
	{
#nullable enable
		private static SpeciesZeraora? _instance = null;
#nullable restore
        public static SpeciesZeraora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZeraora();
                }
                return _instance;
            }
        }

		#region SpeciesZeraora Constructor
		public SpeciesZeraora() : base(
			807,
			"Zeraora",
			1.5,
			44.5,
			88, // HPs
			112, 75, // Attack & Defense
			102, 80, // Special Attack & Defense
			143		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Thunder-Punch",
				"Scratch",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Protect",
				"False-Swipe",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Fake-Out",
				"Facade",
				"Charge",
				"Taunt",
				"Brick-Break",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Close-Combat",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Acrobatics",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Brutal-Swing",
				"Plasma-Fists"
			};
		}
		#endregion
	}
	#endregion

	//Zeraora PokemonInstance Class
	#region Zeraora
	public class ZeraoraInstance : PokemonInstance
	{
		#region Zeraora Constructors
		/// <summary>
		/// Zeraora Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZeraoraInstance(string nickname, int level)
		: base(
				SpeciesZeraora.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Builder only waiting for a Level
		/// </summary>
		public ZeraoraInstance(int level)
		: base(
				SpeciesZeraora.Instance, // PokemonInstance Species
				"Zeraora", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZeraoraInstance() : base(
			SpeciesZeraora.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}