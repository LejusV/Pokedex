using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tauros Species to store common natural stats of all Tauross
	#region SpeciesTauros
	public class SpeciesTauros : PokemonSpecies
	{
#nullable enable
		private static SpeciesTauros? _instance = null;
#nullable restore
        public static SpeciesTauros Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTauros();
                }
                return _instance;
            }
        }

		#region SpeciesTauros Constructor
		public SpeciesTauros() : base(
			128,
			"Tauros",
			1.4,
			88.4,
			75, // HPs
			100, 95, // Attack & Defense
			40, 70, // Special Attack & Defense
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
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Tauros PokemonInstance Class
	#region Tauros
	public class TaurosInstance : PokemonInstance
	{
		#region Tauros Constructors
		/// <summary>
		/// Tauros Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TaurosInstance(string nickname, int level)
		: base(
				SpeciesTauros.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Builder only waiting for a Level
		/// </summary>
		public TaurosInstance(int level)
		: base(
				SpeciesTauros.Instance, // PokemonInstance Species
				"Tauros", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TaurosInstance() : base(
			SpeciesTauros.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}