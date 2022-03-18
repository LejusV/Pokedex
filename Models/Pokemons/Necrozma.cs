using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Necrozma Species to store common natural stats of all Necrozmas
	#region SpeciesNecrozma
	public class SpeciesNecrozma : PokemonSpecies
	{
#nullable enable
		private static SpeciesNecrozma? _instance = null;
#nullable restore
        public static SpeciesNecrozma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNecrozma();
                }
                return _instance;
            }
        }

		#region SpeciesNecrozma Constructor
		public SpeciesNecrozma() : base(
			800,
			"Necrozma",
			2.4,
			230.0,
			97, // HPs
			107, 101, // Attack & Defense
			127, 89, // Special Attack & Defense
			79		
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
				"Swords-Dance",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Morning-Sun",
				"Moonlight",
				"Hidden-Power",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Rock-Blast",
				"Gravity",
				"Gyro-Ball",
				"Embargo",
				"Fling",
				"Wring-Out",
				"Rock-Polish",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Power-Gem",
				"Giga-Impact",
				"Shadow-Claw",
				"Psycho-Cut",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Psyshock",
				"Autotomize",
				"Round",
				"Stored-Power",
				"Bulldoze",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing",
				"Prismatic-Laser",
				"Photon-Geyser"
			};
		}
		#endregion
	}
	#endregion

	//Necrozma PokemonInstance Class
	#region Necrozma
	public class NecrozmaInstance : PokemonInstance
	{
		#region Necrozma Constructors
		/// <summary>
		/// Necrozma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NecrozmaInstance(string nickname, int level)
		: base(
				SpeciesNecrozma.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Builder only waiting for a Level
		/// </summary>
		public NecrozmaInstance(int level)
		: base(
				SpeciesNecrozma.Instance, // PokemonInstance Species
				"Necrozma", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NecrozmaInstance() : base(
			SpeciesNecrozma.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}