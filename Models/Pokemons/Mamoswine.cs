using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mamoswine Species to store common natural stats of all Mamoswines
	#region SpeciesMamoswine
	public class SpeciesMamoswine : PokemonSpecies
	{
#nullable enable
		private static SpeciesMamoswine? _instance = null;
#nullable restore
        public static SpeciesMamoswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMamoswine();
                }
                return _instance;
            }
        }

		#region SpeciesMamoswine Constructor
		public SpeciesMamoswine() : base(
			473,
			"Mamoswine",
			2.5,
			291.0,
			110, // HPs
			130, 80, // Attack & Defense
			70, 60, // Special Attack & Defense
			80		
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
				"Headbutt",
				"Fury-Attack",
				"Take-Down",
				"Thrash",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Block",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Mud-Bomb",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Double-Hit",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mamoswine PokemonInstance Class
	#region Mamoswine
	public class MamoswineInstance : PokemonInstance
	{
		#region Mamoswine Constructors
		/// <summary>
		/// Mamoswine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MamoswineInstance(string nickname, int level)
		: base(
				SpeciesMamoswine.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Builder only waiting for a Level
		/// </summary>
		public MamoswineInstance(int level)
		: base(
				SpeciesMamoswine.Instance, // PokemonInstance Species
				"Mamoswine", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MamoswineInstance() : base(
			SpeciesMamoswine.Instance, // PokemonInstance Species
			Ice.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}