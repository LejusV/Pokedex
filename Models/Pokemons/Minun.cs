using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Minun Species to store common natural stats of all Minuns
	#region SpeciesMinun
	public class SpeciesMinun : PokemonSpecies
	{
#nullable enable
		private static SpeciesMinun? _instance = null;
#nullable restore
        public static SpeciesMinun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMinun();
                }
                return _instance;
            }
        }

		#region SpeciesMinun Constructor
		public SpeciesMinun() : base(
			312,
			"Minun",
			0.4,
			4.2,
			60, // HPs
			40, 50, // Attack & Defense
			75, 85, // Special Attack & Defense
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
				"Trump-Card",
				"Lucky-Chant",
				"Copycat",
				"Last-Resort",
				"Magnet-Rise",
				"Switcheroo",
				"Nasty-Plot",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Entrainment",
				"Round",
				"Echoed-Voice",
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

	//Minun PokemonInstance Class
	#region Minun
	public class MinunInstance : PokemonInstance
	{
		#region Minun Constructors
		/// <summary>
		/// Minun Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MinunInstance(string nickname, int level)
		: base(
				SpeciesMinun.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Builder only waiting for a Level
		/// </summary>
		public MinunInstance(int level)
		: base(
				SpeciesMinun.Instance, // PokemonInstance Species
				"Minun", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MinunInstance() : base(
			SpeciesMinun.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}