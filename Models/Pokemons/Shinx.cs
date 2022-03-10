using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shinx Species to store common natural stats of all Shinxs
	#region SpeciesShinx
	public class SpeciesShinx : PokemonSpecies
	{
#nullable enable
		private static SpeciesShinx? _instance = null;
#nullable restore
        public static SpeciesShinx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShinx();
                }
                return _instance;
            }
        }

		#region SpeciesShinx Constructor
		public SpeciesShinx() : base(
			"Shinx",
			0.5,
			9.5,
			45, // HPs
			65, 34, // Attack & Defense
			40, 34, // Special Attack & Defense
			45		
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
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Night-Slash",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Eerie-Impulse",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Shinx PokemonInstance Class
	#region Shinx
	public class ShinxInstance : PokemonInstance
	{
		#region Shinx Constructors
		/// <summary>
		/// Shinx Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShinxInstance(string nickname, int level)
		: base(
				403,
				SpeciesShinx.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Builder only waiting for a Level
		/// </summary>
		public ShinxInstance(int level)
		: base(
				403,
				SpeciesShinx.Instance, // PokemonInstance Species
				"Shinx", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shinx() : base(
			403,
			SpeciesShinx.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}