using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lunatone Species to store common natural stats of all Lunatones
	#region LunatoneSpecies
	public class LunatoneSpecies : PokemonSpecies
	{
#nullable enable
		private static LunatoneSpecies? _instance = null;
#nullable restore
        public static LunatoneSpecies Instance => _instance ?? (_instance = new LunatoneSpecies());

		#region LunatoneSpecies Constructor
		public LunatoneSpecies() : base(
			337,
			"Lunatone",
			Rock.Instance, Psychic.Instance,
			1.0,
			168.0,
			new PokemonStats(
				90, // HPs
				55, 65, // Attack & Defense
				95, 85, // Spacial Attack & Defense
				70 // Speed
			)			
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
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Embargo",
				"Heal-Block",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Smack-Down",
				"Round",
				"Acrobatics",
				"Bulldoze",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}