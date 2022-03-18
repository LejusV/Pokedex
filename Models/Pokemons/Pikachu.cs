using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pikachu Species to store common natural stats of all Pikachus
	#region SpeciesPikachu
	public class SpeciesPikachu : PokemonSpecies
	{
#nullable enable
		private static SpeciesPikachu? _instance = null;
#nullable restore
        public static SpeciesPikachu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPikachu();
                }
                return _instance;
            }
        }

		#region SpeciesPikachu Constructor
		public SpeciesPikachu() : base(
			25,
			"Pikachu",
			0.4,
			6.0,
			35, // HPs
			55, 40, // Attack & Defense
			50, 50, // Special Attack & Defense
			90		
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
				"Pay-Day",
				"Thunder-Punch",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Surf",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Magnet-Rise",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Play-Nice",
				"Confide",
				"Nuzzle"
			};
		}
		#endregion
	}
	#endregion

	//Pikachu PokemonInstance Class
	#region Pikachu
	public class PikachuInstance : PokemonInstance
	{
		#region Pikachu Constructors
		/// <summary>
		/// Pikachu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PikachuInstance(string nickname, int level)
		: base(
				SpeciesPikachu.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Builder only waiting for a Level
		/// </summary>
		public PikachuInstance(int level)
		: base(
				SpeciesPikachu.Instance, // PokemonInstance Species
				"Pikachu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PikachuInstance() : base(
			SpeciesPikachu.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}