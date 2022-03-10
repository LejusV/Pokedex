using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bastiodon Species to store common natural stats of all Bastiodons
	#region SpeciesBastiodon
	public class SpeciesBastiodon : PokemonSpecies
	{
#nullable enable
		private static SpeciesBastiodon? _instance = null;
#nullable restore
        public static SpeciesBastiodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBastiodon();
                }
                return _instance;
            }
        }

		#region SpeciesBastiodon Constructor
		public SpeciesBastiodon() : base(
			"Bastiodon",
			1.3,
			149.5,
			60, // HPs
			52, 168, // Attack & Defense
			47, 138, // Special Attack & Defense
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
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
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
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
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

	//Bastiodon PokemonInstance Class
	#region Bastiodon
	public class BastiodonInstance : PokemonInstance
	{
		#region Bastiodon Constructors
		/// <summary>
		/// Bastiodon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BastiodonInstance(string nickname, int level)
		: base(
				411,
				SpeciesBastiodon.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Builder only waiting for a Level
		/// </summary>
		public BastiodonInstance(int level)
		: base(
				411,
				SpeciesBastiodon.Instance, // PokemonInstance Species
				"Bastiodon", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bastiodon() : base(
			411,
			SpeciesBastiodon.Instance, // PokemonInstance Species
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}