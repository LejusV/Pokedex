using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arcanine Species to store common natural stats of all Arcanines
	#region SpeciesArcanine
	public class SpeciesArcanine : PokemonSpecies
	{
#nullable enable
		private static SpeciesArcanine? _instance = null;
#nullable restore
        public static SpeciesArcanine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArcanine();
                }
                return _instance;
            }
        }

		#region SpeciesArcanine Constructor
		public SpeciesArcanine() : base(
			59,
			"Arcanine",
			1.9,
			155.0,
			90, // HPs
			110, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			95		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Rage",
				"Teleport",
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
				"Hidden-Power",
				"Sunny-Day",
				"Extreme-Speed",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Covet",
				"Natural-Gift",
				"Dragon-Pulse",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Arcanine PokemonInstance Class
	#region Arcanine
	public class ArcanineInstance : PokemonInstance
	{
		#region Arcanine Constructors
		/// <summary>
		/// Arcanine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArcanineInstance(string nickname, int level)
		: base(
				SpeciesArcanine.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Builder only waiting for a Level
		/// </summary>
		public ArcanineInstance(int level)
		: base(
				SpeciesArcanine.Instance, // PokemonInstance Species
				"Arcanine", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArcanineInstance() : base(
			SpeciesArcanine.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}