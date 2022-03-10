using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pichu Species to store common natural stats of all Pichus
	#region SpeciesPichu
	public class SpeciesPichu : PokemonSpecies
	{
#nullable enable
		private static SpeciesPichu? _instance = null;
#nullable restore
        public static SpeciesPichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPichu();
                }
                return _instance;
            }
        }

		#region SpeciesPichu Constructor
		public SpeciesPichu() : base(
			"Pichu",
			0.3,
			2.0,
			20, // HPs
			40, 15, // Attack & Defense
			35, 35, // Special Attack & Defense
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
				"Double-Slap",
				"Mega-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Counter",
				"Seismic-Toss",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Bide",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Reversal",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Wish",
				"Secret-Power",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Volt-Tackle",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Magnet-Rise",
				"Nasty-Plot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bestow",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Disarming-Voice",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Pichu PokemonInstance Class
	#region Pichu
	public class PichuInstance : PokemonInstance
	{
		#region Pichu Constructors
		/// <summary>
		/// Pichu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PichuInstance(string nickname, int level)
		: base(
				172,
				SpeciesPichu.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Builder only waiting for a Level
		/// </summary>
		public PichuInstance(int level)
		: base(
				172,
				SpeciesPichu.Instance, // PokemonInstance Species
				"Pichu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pichu() : base(
			172,
			SpeciesPichu.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}