using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sharpedo Species to store common natural stats of all Sharpedos
	#region SpeciesSharpedo
	public class SpeciesSharpedo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSharpedo? _instance = null;
#nullable restore
        public static SpeciesSharpedo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSharpedo();
                }
                return _instance;
            }
        }

		#region SpeciesSharpedo Constructor
		public SpeciesSharpedo() : base(
			319,
			"Sharpedo",
			1.8,
			88.8,
			70, // HPs
			120, 40, // Attack & Defense
			95, 40, // Special Attack & Defense
			95		
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
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Poison-Fang",
				"Rock-Tomb",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sharpedo PokemonInstance Class
	#region Sharpedo
	public class SharpedoInstance : PokemonInstance
	{
		#region Sharpedo Constructors
		/// <summary>
		/// Sharpedo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SharpedoInstance(string nickname, int level)
		: base(
				SpeciesSharpedo.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Builder only waiting for a Level
		/// </summary>
		public SharpedoInstance(int level)
		: base(
				SpeciesSharpedo.Instance, // PokemonInstance Species
				"Sharpedo", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SharpedoInstance() : base(
			SpeciesSharpedo.Instance, // PokemonInstance Species
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}