using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jynx Species to store common natural stats of all Jynxs
	#region JynxSpecies
	public class JynxSpecies : PokemonSpecies
	{
#nullable enable
		private static JynxSpecies? _instance = null;
#nullable restore
        public static JynxSpecies Instance => _instance ?? (_instance = new JynxSpecies());

		#region JynxSpecies Constructor
		public JynxSpecies() : base(
			124,
			"Jynx",
			Ice.Instance, Psychic.Instance,
			1.4,
			40.6,
			new PokemonStats(
				65, // HPs
				50, 35, // Attack & Defense
				115, 95, // Spacial Attack & Defense
				95 // Speed
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
				"Pound",
				"Double-Slap",
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Lick",
				"Skull-Bash",
				"Dream-Eater",
				"Lovely-Kiss",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Heart-Stamp",
				"Draining-Kiss",
				"Confide",
				"Power-Up-Punch",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}