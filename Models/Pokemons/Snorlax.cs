using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snorlax Specie to store common natural stats of every {'abilities': ['immunity', 'thick-fat', 'gluttony'], 'base_experience': 189, 'height': 21, 'id': 143, 'moves': ['mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'whirlwind', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'toxic', 'psychic', 'rage', 'mimic', 'double-team', 'harden', 'defense-curl', 'reflect', 'bide', 'metronome', 'self-destruct', 'lick', 'fire-blast', 'skull-bash', 'amnesia', 'psywave', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'zap-cannon', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'focus-punch', 'superpower', 'recycle', 'brick-break', 'yawn', 'secret-power', 'hyper-voice', 'rock-tomb', 'block', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'last-resort', 'seed-bomb', 'focus-blast', 'giga-impact', 'zen-headbutt', 'rock-climb', 'gunk-shot', 'iron-head', 'captivate', 'smack-down', 'heavy-slam', 'after-you', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'belch', 'confide', 'power-up-punch', 'high-horsepower'], 'name': 'snorlax', 'stats': {'hp': 160, 'attack': 110, 'defense': 65, 'special-attack': 65, 'special-defense': 110, 'speed': 30}, 'types': ['normal'], 'weight': 4600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 1, 'capture_rate': 25, 'color': 'black', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'カビゴン', 'roomaji': 'Kabigon', 'ko': '잠만보', 'zh-Hant': '卡比獸', 'fr': 'Ronflex', 'de': 'Relaxo', 'es': 'Snorlax', 'it': 'Snorlax', 'en': 'Snorlax', 'ja': 'カビゴン', 'zh-Hans': '卡比兽'}, 'genera': {'ja-Hrkt': 'いねむりポケモン', 'ko': '졸음포켓몬', 'zh-Hant': '瞌睡寶可夢', 'fr': 'Pokémon Pionceur', 'de': 'Tagträumer', 'es': 'Pokémon Dormir', 'it': 'Pokémon Sonno', 'en': 'Sleeping Pokémon', 'ja': 'いねむりポケモン', 'zh-Hans': '瞌睡宝可梦'}}
	public class SpecieSnorlax : PokemonSpecie
	{
#nullable enable
		private static SpecieSnorlax? _instance = null;
#nullable restore
        public static SpecieSnorlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnorlax();
                }
                return _instance;
            }
        }

		public SpecieSnorlax() : base(
			"Snorlax",
			160, // HPs
			110, 65, // Attack & Defense
			65, 110, // Special Attack & Defense
			30			
		) {}
	}


	//Snorlax Pokemon Class
	public class Snorlax : Pokemon
	{

		public Snorlax(string nickname, int level) : base(
			143,
			SpecieSnorlax.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Snorlax() : base(
			143,
			SpecieSnorlax.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}