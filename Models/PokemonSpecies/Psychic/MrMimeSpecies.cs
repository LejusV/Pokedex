using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mr-Mime Species to store common natural stats of all Mr-Mimes
	#region Mr-MimeSpecies
	public class MrMimeSpecies : PokemonSpecies
	{
#nullable enable
		private static MrMimeSpecies? _instance = null;
#nullable restore
        public static MrMimeSpecies Instance => _instance ?? (_instance = new MrMimeSpecies());

		#region Mr-MimeSpecies Constructor
		public MrMimeSpecies() : base(
			122,
			"Mr-Mime",
			Psychic.Instance, Fairy.Instance,
			1.3,
			54.5,
			new PokemonStats(
				40, // HPs
				45, 65, // Attack & Defense
				100, 120, // Spacial Attack & Defense
				90 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Psybeam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Fake-Out",
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
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Copycat",
				"Power-Swap",
				"Guard-Swap",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wide-Guard",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Quick-Guard",
				"Misty-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}