using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Growlithe Species to store common natural stats of all Growlithes
	#region SpeciesGrowlithe
	public class SpeciesGrowlithe : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrowlithe? _instance = null;
#nullable restore
        public static SpeciesGrowlithe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrowlithe();
                }
                return _instance;
            }
        }

		#region SpeciesGrowlithe Constructor
		public SpeciesGrowlithe() : base(
			58,
			"Growlithe",
			0.7,
			19.0,
			55, // HPs
			70, 45, // Attack & Defense
			70, 50, // Special Attack & Defense
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
				"Double-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Dragon-Rage",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Close-Combat",
				"Flare-Blitz",
				"Fire-Fang",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Retaliate",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion

	//Growlithe PokemonInstance Class
	#region Growlithe
	public class GrowlitheInstance : PokemonInstance
	{
		#region Growlithe Constructors
		/// <summary>
		/// Growlithe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrowlitheInstance(string nickname, int level)
		: base(
				SpeciesGrowlithe.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Builder only waiting for a Level
		/// </summary>
		public GrowlitheInstance(int level)
		: base(
				SpeciesGrowlithe.Instance, // PokemonInstance Species
				"Growlithe", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrowlitheInstance() : base(
			SpeciesGrowlithe.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}