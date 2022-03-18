using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Raichu Species to store common natural stats of all Raichus
	#region SpeciesRaichu
	public class SpeciesRaichu : PokemonSpecies
	{
#nullable enable
		private static SpeciesRaichu? _instance = null;
#nullable restore
        public static SpeciesRaichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRaichu();
                }
                return _instance;
            }
        }

		#region SpeciesRaichu Constructor
		public SpeciesRaichu() : base(
			26,
			"Raichu",
			0.8,
			30.0,
			60, // HPs
			90, 55, // Attack & Defense
			90, 80, // Special Attack & Defense
			110		
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Hyper-Beam",
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
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
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
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Raichu PokemonInstance Class
	#region Raichu
	public class RaichuInstance : PokemonInstance
	{
		#region Raichu Constructors
		/// <summary>
		/// Raichu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RaichuInstance(string nickname, int level)
		: base(
				SpeciesRaichu.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Builder only waiting for a Level
		/// </summary>
		public RaichuInstance(int level)
		: base(
				SpeciesRaichu.Instance, // PokemonInstance Species
				"Raichu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RaichuInstance() : base(
			SpeciesRaichu.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}