using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shieldon Species to store common natural stats of all Shieldons
	#region SpeciesShieldon
	public class SpeciesShieldon : PokemonSpecies
	{
#nullable enable
		private static SpeciesShieldon? _instance = null;
#nullable restore
        public static SpeciesShieldon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShieldon();
                }
                return _instance;
            }
        }

		#region SpeciesShieldon Constructor
		public SpeciesShieldon() : base(
			410,
			"Shieldon",
			0.5,
			57.0,
			30, // HPs
			42, 118, // Attack & Defense
			42, 88, // Special Attack & Defense
			30		
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Rock-Blast",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Guard-Split",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Shieldon PokemonInstance Class
	#region Shieldon
	public class ShieldonInstance : PokemonInstance
	{
		#region Shieldon Constructors
		/// <summary>
		/// Shieldon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShieldonInstance(string nickname, int level)
		: base(
				SpeciesShieldon.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Builder only waiting for a Level
		/// </summary>
		public ShieldonInstance(int level)
		: base(
				SpeciesShieldon.Instance, // PokemonInstance Species
				"Shieldon", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShieldonInstance() : base(
			SpeciesShieldon.Instance, // PokemonInstance Species
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}