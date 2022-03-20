using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mime-Jr Species to store common natural stats of all Mime-Jrs
	#region Mime-JrSpecies
	public class MimeJrSpecies : PokemonSpecies
	{
#nullable enable
		private static MimeJrSpecies? _instance = null;
#nullable restore
        public static MimeJrSpecies Instance => _instance ?? (_instance = new MimeJrSpecies());

		#region Mime-JrSpecies Constructor
		public MimeJrSpecies() : base(
			439,
			"Mime-Jr",
			Psychic.Instance, Fairy.Instance,
			0.6,
			13.0,
			new PokemonStats(
				20, // HPs
				25, 45, // Attack & Defense
				70, 90, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Psybeam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Fake-Out",
				"Uproar",
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
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Drain-Punch",
				"Nasty-Plot",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Confide",
				"Infestation",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}