using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pachirisu Species to store common natural stats of all Pachirisus
	#region SpeciesPachirisu
	public class SpeciesPachirisu : PokemonSpecies
	{
#nullable enable
		private static SpeciesPachirisu? _instance = null;
#nullable restore
        public static SpeciesPachirisu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPachirisu();
                }
                return _instance;
            }
        }

		#region SpeciesPachirisu Constructor
		public SpeciesPachirisu() : base(
			417,
			"Pachirisu",
			0.4,
			3.9,
			60, // HPs
			45, 70, // Attack & Defense
			45, 90, // Special Attack & Defense
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
				"Thunder-Punch",
				"Cut",
				"Headbutt",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Bide",
				"Swift",
				"Flash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Flatter",
				"Facade",
				"Follow-Me",
				"Charge",
				"Helping-Hand",
				"Secret-Power",
				"Fake-Tears",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Magnet-Rise",
				"Seed-Bomb",
				"Discharge",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Ion-Deluge",
				"Confide",
				"Baby-Doll-Eyes",
				"Nuzzle"
			};
		}
		#endregion
	}
	#endregion

	//Pachirisu PokemonInstance Class
	#region Pachirisu
	public class PachirisuInstance : PokemonInstance
	{
		#region Pachirisu Constructors
		/// <summary>
		/// Pachirisu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PachirisuInstance(string nickname, int level)
		: base(
				SpeciesPachirisu.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Builder only waiting for a Level
		/// </summary>
		public PachirisuInstance(int level)
		: base(
				SpeciesPachirisu.Instance, // PokemonInstance Species
				"Pachirisu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pachirisu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PachirisuInstance() : base(
			SpeciesPachirisu.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}