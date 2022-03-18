using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ampharos Species to store common natural stats of all Amphaross
	#region SpeciesAmpharos
	public class SpeciesAmpharos : PokemonSpecies
	{
#nullable enable
		private static SpeciesAmpharos? _instance = null;
#nullable restore
        public static SpeciesAmpharos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAmpharos();
                }
                return _instance;
            }
        }

		#region SpeciesAmpharos Constructor
		public SpeciesAmpharos() : base(
			181,
			"Ampharos",
			1.4,
			61.5,
			90, // HPs
			75, 85, // Attack & Defense
			115, 90, // Special Attack & Defense
			55		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
				"Zap-Cannon",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Charge",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Dragon-Pulse",
				"Power-Gem",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Bulldoze",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Ion-Deluge",
				"Confide",
				"Magnetic-Flux",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Ampharos PokemonInstance Class
	#region Ampharos
	public class AmpharosInstance : PokemonInstance
	{
		#region Ampharos Constructors
		/// <summary>
		/// Ampharos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AmpharosInstance(string nickname, int level)
		: base(
				SpeciesAmpharos.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Builder only waiting for a Level
		/// </summary>
		public AmpharosInstance(int level)
		: base(
				SpeciesAmpharos.Instance, // PokemonInstance Species
				"Ampharos", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AmpharosInstance() : base(
			SpeciesAmpharos.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}