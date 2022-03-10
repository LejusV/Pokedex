using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Octillery Species to store common natural stats of all Octillerys
	#region SpeciesOctillery
	public class SpeciesOctillery : PokemonSpecies
	{
#nullable enable
		private static SpeciesOctillery? _instance = null;
#nullable restore
        public static SpeciesOctillery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOctillery();
                }
                return _instance;
            }
        }

		#region SpeciesOctillery Constructor
		public SpeciesOctillery() : base(
			"Octillery",
			0.9,
			28.5,
			75, // HPs
			105, 75, // Attack & Defense
			105, 75, // Special Attack & Defense
			45		
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
				"Bind",
				"Double-Edge",
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
				"Seismic-Toss",
				"String-Shot",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Constrict",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Octazooka",
				"Icy-Wind",
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
				"Signal-Beam",
				"Bullet-Seed",
				"Bounce",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Wring-Out",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Gunk-Shot",
				"Captivate",
				"Charge-Beam",
				"Smack-Down",
				"Sludge-Wave",
				"Soak",
				"Round",
				"Scald",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Octillery PokemonInstance Class
	#region Octillery
	public class OctilleryInstance : PokemonInstance
	{
		#region Octillery Constructors
		/// <summary>
		/// Octillery Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OctilleryInstance(string nickname, int level)
		: base(
				224,
				SpeciesOctillery.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Builder only waiting for a Level
		/// </summary>
		public OctilleryInstance(int level)
		: base(
				224,
				SpeciesOctillery.Instance, // PokemonInstance Species
				"Octillery", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Octillery() : base(
			224,
			SpeciesOctillery.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}