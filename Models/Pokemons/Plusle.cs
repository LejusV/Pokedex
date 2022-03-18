using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Plusle Species to store common natural stats of all Plusles
	#region SpeciesPlusle
	public class SpeciesPlusle : PokemonSpecies
	{
#nullable enable
		private static SpeciesPlusle? _instance = null;
#nullable restore
        public static SpeciesPlusle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPlusle();
                }
                return _instance;
            }
        }

		#region SpeciesPlusle Constructor
		public SpeciesPlusle() : base(
			311,
			"Plusle",
			0.4,
			4.2,
			60, // HPs
			50, 40, // Attack & Defense
			85, 75, // Special Attack & Defense
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
				"Mega-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Sing",
				"Counter",
				"Seismic-Toss",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Metronome",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
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
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Wish",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Copycat",
				"Last-Resort",
				"Magnet-Rise",
				"Nasty-Plot",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Play-Nice",
				"Confide",
				"Nuzzle",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Plusle PokemonInstance Class
	#region Plusle
	public class PlusleInstance : PokemonInstance
	{
		#region Plusle Constructors
		/// <summary>
		/// Plusle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PlusleInstance(string nickname, int level)
		: base(
				SpeciesPlusle.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Builder only waiting for a Level
		/// </summary>
		public PlusleInstance(int level)
		: base(
				SpeciesPlusle.Instance, // PokemonInstance Species
				"Plusle", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PlusleInstance() : base(
			SpeciesPlusle.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}