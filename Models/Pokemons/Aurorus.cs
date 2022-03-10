using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aurorus Species to store common natural stats of all Auroruss
	#region SpeciesAurorus
	public class SpeciesAurorus : PokemonSpecies
	{
#nullable enable
		private static SpeciesAurorus? _instance = null;
#nullable restore
        public static SpeciesAurorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAurorus();
                }
                return _instance;
            }
        }

		#region SpeciesAurorus Constructor
		public SpeciesAurorus() : base(
			"Aurorus",
			2.7,
			225.0,
			123, // HPs
			77, 72, // Attack & Defense
			99, 92, // Special Attack & Defense
			58		
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
				"Take-Down",
				"Growl",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Iron-Defense",
				"Calm-Mind",
				"Water-Pulse",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Dragon-Tail",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Aurorus PokemonInstance Class
	#region Aurorus
	public class AurorusInstance : PokemonInstance
	{
		#region Aurorus Constructors
		/// <summary>
		/// Aurorus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AurorusInstance(string nickname, int level)
		: base(
				699,
				SpeciesAurorus.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Builder only waiting for a Level
		/// </summary>
		public AurorusInstance(int level)
		: base(
				699,
				SpeciesAurorus.Instance, // PokemonInstance Species
				"Aurorus", level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Aurorus() : base(
			699,
			SpeciesAurorus.Instance, // PokemonInstance Species
			Rock.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}