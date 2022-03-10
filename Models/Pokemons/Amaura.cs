using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Amaura Species to store common natural stats of all Amauras
	#region SpeciesAmaura
	public class SpeciesAmaura : PokemonSpecies
	{
#nullable enable
		private static SpeciesAmaura? _instance = null;
#nullable restore
        public static SpeciesAmaura Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAmaura();
                }
                return _instance;
            }
        }

		#region SpeciesAmaura Constructor
		public SpeciesAmaura() : base(
			"Amaura",
			1.3,
			25.2,
			77, // HPs
			59, 50, // Attack & Defense
			67, 63, // Special Attack & Defense
			46		
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
				"Rock-Throw",
				"Toxic",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Haze",
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
				"Mirror-Coat",
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
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Discharge",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Amaura PokemonInstance Class
	#region Amaura
	public class AmauraInstance : PokemonInstance
	{
		#region Amaura Constructors
		/// <summary>
		/// Amaura Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AmauraInstance(string nickname, int level)
		: base(
				698,
				SpeciesAmaura.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Builder only waiting for a Level
		/// </summary>
		public AmauraInstance(int level)
		: base(
				698,
				SpeciesAmaura.Instance, // PokemonInstance Species
				"Amaura", level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Amaura() : base(
			698,
			SpeciesAmaura.Instance, // PokemonInstance Species
			Rock.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}