using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Guzzlord Species to store common natural stats of all Guzzlords
	#region SpeciesGuzzlord
	public class SpeciesGuzzlord : PokemonSpecies
	{
#nullable enable
		private static SpeciesGuzzlord? _instance = null;
#nullable restore
        public static SpeciesGuzzlord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGuzzlord();
                }
                return _instance;
            }
        }

		#region SpeciesGuzzlord Constructor
		public SpeciesGuzzlord() : base(
			"Guzzlord",
			5.5,
			888.0,
			223, // HPs
			101, 53, // Attack & Defense
			97, 53, // Special Attack & Defense
			43		
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
				"Stomp",
				"Thrash",
				"Bite",
				"Flamethrower",
				"Hyper-Beam",
				"Dragon-Rage",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Stockpile",
				"Swallow",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Dragon-Claw",
				"Hammer-Arm",
				"Gyro-Ball",
				"Payback",
				"Fling",
				"Wring-Out",
				"Gastro-Acid",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Rush",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Stone-Edge",
				"Wide-Guard",
				"Smack-Down",
				"Sludge-Wave",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Steamroller",
				"Snarl",
				"Belch",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Guzzlord PokemonInstance Class
	#region Guzzlord
	public class GuzzlordInstance : PokemonInstance
	{
		#region Guzzlord Constructors
		/// <summary>
		/// Guzzlord Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GuzzlordInstance(string nickname, int level)
		: base(
				799,
				SpeciesGuzzlord.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Builder only waiting for a Level
		/// </summary>
		public GuzzlordInstance(int level)
		: base(
				799,
				SpeciesGuzzlord.Instance, // PokemonInstance Species
				"Guzzlord", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Guzzlord() : base(
			799,
			SpeciesGuzzlord.Instance, // PokemonInstance Species
			Dark.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}