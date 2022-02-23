using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clefairy Specie to store common natural stats of every {'abilities': ['cute-charm', 'magic-guard', 'friend-guard'], 'base_experience': 113, 'height': 6, 'id': 35, 'moves': ['pound', 'double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'growl', 'sing', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'minimize', 'defense-curl', 'light-screen', 'reflect', 'bide', 'metronome', 'fire-blast', 'skull-bash', 'soft-boiled', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'encore', 'iron-tail', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'follow-me', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'meteor-mash', 'cosmic-power', 'signal-beam', 'bounce', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'wake-up-slap', 'healing-wish', 'natural-gift', 'fling', 'lucky-chant', 'last-resort', 'drain-punch', 'zen-headbutt', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'stored-power', 'incinerate', 'retaliate', 'bestow', 'work-up', 'disarming-voice', 'moonblast', 'confide', 'dazzling-gleam', 'power-up-punch', 'spotlight'], 'name': 'clefairy', 'stats': {'hp': 70, 'attack': 45, 'defense': 48, 'special-attack': 60, 'special-defense': 65, 'speed': 35}, 'types': ['fairy'], 'weight': 75, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 150, 'color': 'pink', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ピッピ', 'roomaji': 'Pippi', 'ko': '삐삐', 'zh-Hant': '皮皮', 'fr': 'Mélofée', 'de': 'Piepi', 'es': 'Clefairy', 'it': 'Clefairy', 'en': 'Clefairy', 'ja': 'ピッピ', 'zh-Hans': '皮皮'}, 'genera': {'ja-Hrkt': 'ようせいポケモン', 'ko': '요정포켓몬', 'zh-Hant': '妖精寶可夢', 'fr': 'Pokémon Fée', 'de': 'Fee', 'es': 'Pokémon Hada', 'it': 'Pokémon Fata', 'en': 'Fairy Pokémon', 'ja': 'ようせいポケモン', 'zh-Hans': '妖精宝可梦'}}
	public class SpecieClefairy : PokemonSpecie
	{
#nullable enable
		private static SpecieClefairy? _instance = null;
#nullable restore
        public static SpecieClefairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClefairy();
                }
                return _instance;
            }
        }

		public SpecieClefairy() : base(
			"Clefairy",
			70, // HPs
			45, 48, // Attack & Defense
			60, 65, // Special Attack & Defense
			35			
		) {}
	}


	//Clefairy Pokemon Class
	public class Clefairy : Pokemon
	{

		public Clefairy(string nickname, int level) : base(
			35,
			SpecieClefairy.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Clefairy() : base(
			35,
			SpecieClefairy.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}