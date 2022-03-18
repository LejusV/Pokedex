using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Incineroar Species to store common natural stats of all Incineroars
	#region SpeciesIncineroar
	public class SpeciesIncineroar : PokemonSpecies
	{
#nullable enable
		private static SpeciesIncineroar? _instance = null;
#nullable restore
        public static SpeciesIncineroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesIncineroar();
                }
                return _instance;
            }
        }

		#region SpeciesIncineroar Constructor
		public SpeciesIncineroar() : base(
			727,
			"Incineroar",
			1.8,
			83.0,
			95, // HPs
			115, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
			60		
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
				"Scratch",
				"Swords-Dance",
				"Double-Kick",
				"Thrash",
				"Leer",
				"Bite",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Leech-Life",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Cross-Chop",
				"Sunny-Day",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Blast-Burn",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Embargo",
				"Fling",
				"Flare-Blitz",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Quash",
				"Acrobatics",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Snarl",
				"Confide",
				"Darkest-Lariat",
				"Throat-Chop",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Incineroar PokemonInstance Class
	#region Incineroar
	public class IncineroarInstance : PokemonInstance
	{
		#region Incineroar Constructors
		/// <summary>
		/// Incineroar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IncineroarInstance(string nickname, int level)
		: base(
				SpeciesIncineroar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Builder only waiting for a Level
		/// </summary>
		public IncineroarInstance(int level)
		: base(
				SpeciesIncineroar.Instance, // PokemonInstance Species
				"Incineroar", level,
				Fire.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public IncineroarInstance() : base(
			SpeciesIncineroar.Instance, // PokemonInstance Species
			Fire.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}