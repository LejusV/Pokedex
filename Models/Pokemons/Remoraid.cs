using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Remoraid Species to store common natural stats of all Remoraids
	#region SpeciesRemoraid
	public class SpeciesRemoraid : PokemonSpecies
	{
#nullable enable
		private static SpeciesRemoraid? _instance = null;
#nullable restore
        public static SpeciesRemoraid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRemoraid();
                }
                return _instance;
            }
        }

		#region SpeciesRemoraid Constructor
		public SpeciesRemoraid() : base(
			"Remoraid",
			0.6,
			12.0,
			35, // HPs
			65, 35, // Attack & Defense
			65, 35, // Special Attack & Defense
			65		
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
				"Double-Edge",
				"Supersonic",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"String-Shot",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Focus-Energy",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Octazooka",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Facade",
				"Secret-Power",
				"Dive",
				"Water-Spout",
				"Signal-Beam",
				"Bullet-Seed",
				"Bounce",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Charge-Beam",
				"Smack-Down",
				"Soak",
				"Acid-Spray",
				"Entrainment",
				"Round",
				"Scald",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Remoraid PokemonInstance Class
	#region Remoraid
	public class RemoraidInstance : PokemonInstance
	{
		#region Remoraid Constructors
		/// <summary>
		/// Remoraid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RemoraidInstance(string nickname, int level)
		: base(
				223,
				SpeciesRemoraid.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Builder only waiting for a Level
		/// </summary>
		public RemoraidInstance(int level)
		: base(
				223,
				SpeciesRemoraid.Instance, // PokemonInstance Species
				"Remoraid", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Remoraid() : base(
			223,
			SpeciesRemoraid.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}